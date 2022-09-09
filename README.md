# Zebra RFID IoT Connector - MQTT - GPIO Sample
.NET Sample to control GPOs on Zebra FX Readers using the new IoT Connector and MQTT

## Connect yours RFID Reader

### Prerequisites
- Supported Readers FX7500, FX9600, ATR7000
- Firmware version 3.10.30 or above
- Reader connected to the same network of your local machine

### Setup
- Follow MQTT endpoint configuration guide: https://zebradevs.github.io/rfid-ziotc-docs/other_cloud_support/MQTT/web.html.
- Use your local machine IP as Server Address.
- Default port is 1883.

#### Connection Setup
![image](https://user-images.githubusercontent.com/101400857/180752287-0b3665b9-24d1-4b24-a87e-62c719e3e0a1.png)
![image](https://user-images.githubusercontent.com/101400857/180755415-9a43a8de-f705-48f8-b6a5-9a8248ed9efd.png)

#### Topic Setup
Control Command is the one to be used on our Console App to send commands to change GPOs status

![image](https://user-images.githubusercontent.com/101400857/180752210-b31faf90-e091-493c-b3a0-75340c280895.png)

Now your reader is connected to our Demo app.
Start reading tags and enjoy.

