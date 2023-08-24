namespace CPU_Stats_via_MQTT
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label_hardwareName = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label_cpuLoad = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label_fanSpeed = new System.Windows.Forms.Label();
            this.label_cpuTemp = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.label_mqttStatus = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_hardwareName
            // 
            this.label_hardwareName.AutoSize = true;
            this.label_hardwareName.Location = new System.Drawing.Point(23, 30);
            this.label_hardwareName.Name = "label_hardwareName";
            this.label_hardwareName.Size = new System.Drawing.Size(78, 21);
            this.label_hardwareName.TabIndex = 0;
            this.label_hardwareName.Text = "Hardware";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label_cpuLoad);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label_fanSpeed);
            this.groupBox1.Controls.Add(this.label_cpuTemp);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(27, 77);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(557, 237);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "CPU Stats";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label_cpuLoad
            // 
            this.label_cpuLoad.AutoSize = true;
            this.label_cpuLoad.Location = new System.Drawing.Point(217, 94);
            this.label_cpuLoad.Name = "label_cpuLoad";
            this.label_cpuLoad.Size = new System.Drawing.Size(32, 21);
            this.label_cpuLoad.TabIndex = 5;
            this.label_cpuLoad.Text = "...%";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 21);
            this.label1.TabIndex = 4;
            this.label1.Text = "Load";
            // 
            // label_fanSpeed
            // 
            this.label_fanSpeed.AutoSize = true;
            this.label_fanSpeed.Location = new System.Drawing.Point(197, 126);
            this.label_fanSpeed.Name = "label_fanSpeed";
            this.label_fanSpeed.Size = new System.Drawing.Size(52, 21);
            this.label_fanSpeed.TabIndex = 3;
            this.label_fanSpeed.Text = "...RPM";
            // 
            // label_cpuTemp
            // 
            this.label_cpuTemp.AutoSize = true;
            this.label_cpuTemp.Location = new System.Drawing.Point(214, 58);
            this.label_cpuTemp.Name = "label_cpuTemp";
            this.label_cpuTemp.Size = new System.Drawing.Size(35, 21);
            this.label_cpuTemp.TabIndex = 2;
            this.label_cpuTemp.Text = "...°C";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 21);
            this.label3.TabIndex = 1;
            this.label3.Text = "Fan Speed";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "Temp";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 451);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 21);
            this.label4.TabIndex = 2;
            this.label4.Text = "MQTT Connection:";
            // 
            // label_mqttStatus
            // 
            this.label_mqttStatus.AutoSize = true;
            this.label_mqttStatus.ForeColor = System.Drawing.Color.Black;
            this.label_mqttStatus.Location = new System.Drawing.Point(172, 451);
            this.label_mqttStatus.Name = "label_mqttStatus";
            this.label_mqttStatus.Size = new System.Drawing.Size(101, 21);
            this.label_mqttStatus.TabIndex = 3;
            this.label_mqttStatus.Text = "connecting.....";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 481);
            this.Controls.Add(this.label_mqttStatus);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label_hardwareName);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "CPU Stats via MQTT";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_hardwareName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label_fanSpeed;
        private System.Windows.Forms.Label label_cpuTemp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label_cpuLoad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label_mqttStatus;
    }
}

