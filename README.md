# CPU Stats via MQTT App

The **CPU Stats via MQTT** app is a Windows Forms application that monitors CPU temperature and load and publishes this information to an MQTT broker. This allows you to remotely track your CPU's performance and temperature using MQTT topics.

## Table of Contents

- [Introduction](#introduction)
- [Getting Started](#getting-started)
  - [Prerequisites](#prerequisites)
  - [Installation](#installation)
- [Usage](#usage)
- [MQTT Configuration](#mqtt-configuration)
- [Contributing](#contributing)

## Introduction

The **CPU Stats via MQTT** app is designed to provide real-time monitoring of your CPU's temperature and load. It utilizes the OpenHardwareMonitor library to gather hardware information and the MQTTnet library to establish a connection to an MQTT broker. The collected CPU data is then published to specific MQTT topics, enabling you to integrate the app into your home automation or monitoring setup.

## Getting Started

### Prerequisites

Before using the app, make sure you have the following:

- Windows operating system
- .NET Framework installed
- An MQTT broker (e.g., Mosquitto) running on your network

### Installation

1. Clone or download this repository to your local machine.
2. Open the project using Visual Studio or your preferred C# IDE.
3. Build the project to ensure all dependencies are resolved.

## Usage

1. Launch the **CPU Stats via MQTT** application.
2. The app will automatically start monitoring your CPU's temperature and load.
3. The collected data will be published to MQTT topics based on the configuration.
4. You can customize the MQTT configuration as described in the next section.

## MQTT Configuration

To configure the MQTT connection, modify the following lines in the `Form1_Load` method of the `Form1` class:

```csharp
var options = new MqttClientOptionsBuilder()
    .WithTcpServer("192.168.29.100")  // Replace with your broker IP address
    .WithClientId("cpuapp123")  // Replace with your client ID
    .WithCredentials("home", "Marshmallow")  // Replace with your MQTT username and password
    .Build();

```
Update the WithTcpServer method with your MQTT broker's IP address, WithClientId with your desired client ID, and WithCredentials with your MQTT username and password.

## Contributing

Contributions are welcome! If you encounter any issues or have suggestions for improvements, feel free to open an issue or submit a pull request in this repository.


