using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using OpenHardwareMonitor.Hardware;

using MQTTnet;
using MQTTnet.Client;
using MQTTnet.Exceptions;
using System.Runtime.Serialization.Formatters;
//using MQTTnet.Client.Options;

namespace CPU_Stats_via_MQTT
{

    public partial class Form1 : Form
    {
        Computer myComputer;
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private IMqttClient mqttClient;

        private async void Form1_Load(object sender, EventArgs e)
        {
            myComputer = new Computer() { CPUEnabled = true, MainboardEnabled = true };
            myComputer.Open();

            // Initialize MQTT client
            try
            {
                var factory = new MqttFactory();
                mqttClient = factory.CreateMqttClient();

                var options = new MqttClientOptionsBuilder()
                    .WithTcpServer("192.168.29.1020")  // Replace with your broker IP address
                    .WithClientId("cpuapp123")  // Replace with your client ID
                    .WithCredentials("home", "Marshmallow")  // Replace your_username with the actual username
                    .Build();

                var connectResult = await mqttClient.ConnectAsync(options);

                if (connectResult.ResultCode == MqttClientConnectResultCode.Success)
                {
                    Console.WriteLine("MQTT Connection Successful");
                    // or show a MessageBox
                    // MessageBox.Show("MQTT Connection Successful");
                    label_mqttStatus.ForeColor = Color.Green;
                    label_mqttStatus.Text = "Connection Successful";
                }
                else
                {
                    Console.WriteLine("MQTT Connection Failed: {connectResult.ResultCode}");
                    // or show a MessageBox
                    // MessageBox.Show("MQTT Connection Failed");
                    label_mqttStatus.ForeColor = Color.Red;
                    label_mqttStatus.Text = "Connection Failed: {connectResult.ResultCode}";
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
                // or show a MessageBox
                // MessageBox.Show($"An error occurred: {ex.Message}");
                label_mqttStatus.ForeColor = Color.Red;
                label_mqttStatus.Text = $"An error occurred: {ex.Message}";
            }
        }

        private async void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                foreach (var hardwareItem in myComputer.Hardware)
                {
                    hardwareItem.Update();

                    if (hardwareItem.HardwareType == HardwareType.CPU)
                    {
                        string hardwareName = hardwareItem.Name; // Get the CPU's hardware name
                        float temp = 0;
                        float load = 0;

                        foreach (var sensor in hardwareItem.Sensors)
                        {
                            if (sensor.SensorType == SensorType.Temperature && sensor.Name == "CPU Package" && sensor.Value.HasValue)
                            {
                                temp = sensor.Value.Value;
                            }
                            if (sensor.SensorType == SensorType.Load && sensor.Name == "CPU Total" && sensor.Value.HasValue)

                            {
                                load = sensor.Value.Value;
                            }
                        }

                        label_hardwareName.Text = "Processor: " + hardwareName;
                        label_cpuTemp.Text = temp.ToString("0.00" + " °C");
                        label_cpuLoad.Text = Math.Round(load, 1).ToString("0.0");

                        // Publish temperature data
                        string tempTopic = "home/desktop/main/cpu/temp_data";
                        string tempPayload = temp.ToString();
                        var tempMessage = new MqttApplicationMessageBuilder()
                            .WithTopic(tempTopic)
                            .WithPayload(tempPayload)
                            .Build();


                        // Publish load data
                        string loadTopic = "home/desktop/main/cpu/total_load_data";
                        string loadPayload = Math.Round(load, 1).ToString("0.0");
                        var loadMessage = new MqttApplicationMessageBuilder()
                            .WithTopic(loadTopic)
                            .WithPayload(loadPayload)
                            .Build();

                        if (mqttClient.IsConnected)
                        {
                            await mqttClient.PublishAsync(tempMessage);
                            await mqttClient.PublishAsync(loadMessage);
                        }
                        else
                        {
                            Console.WriteLine("MQTT Client is not connected.");
                            // or show a MessageBox
                            // MessageBox.Show("MQTT Client is not connected.");
                        }
                    }

                }
            }
            catch (MqttCommunicationException ex)
            {
                Console.WriteLine($"MQTT Communication Exception: {ex.Message}");
                // or show a MessageBox
                // MessageBox.Show($"MQTT Communication Exception: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
                // or show a MessageBox
                // MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }


    }


}
