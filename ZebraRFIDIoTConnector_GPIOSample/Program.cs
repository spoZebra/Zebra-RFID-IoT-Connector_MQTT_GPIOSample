
using MQTTnet.Server;
using MQTTnet;
using ZebraRFIDIoTConnector_GPIOSample;
using ZebraRFIDIoTConnector_GPIOSample.Model;
using Newtonsoft.Json;

try
{
    var mqttClientService = new MQTTClientService();

    var mqttFactory = new MqttFactory();

    var mqttServerOptions = new MqttServerOptionsBuilder().WithDefaultEndpoint().WithDefaultEndpoint().WithDefaultEndpointPort(1883).Build();

    using (var mqttServer = mqttFactory.CreateMqttServer(mqttServerOptions))
    {
        Console.WriteLine("Starting MQTT Server...");
        await mqttServer.StartAsync();
        Console.WriteLine("MQTT Server started!");
       
        // Connect
        await mqttClientService.Connect("localhost");
        // Subscribe to everything
        await mqttClientService.Subscribe("#");
        Console.WriteLine("Enter Control topic name:");
        var topic = Console.ReadLine();

        while (true)
        {
            try
            {
                Console.WriteLine("Enter port number:");
                var portNum = Console.ReadLine();
                Console.WriteLine("Set high low state (H/L):");
                var state = Console.ReadLine() == "H" ? true : false;

                // Send command
                await mqttClientService.Publish(topic, new RAWMQTTCommand()
                {
                    Command = "set_gpo",
                    CommandId = DateTime.Now.Ticks.ToString(),
                    Payload = new SetGpoCommand()
                    {
                        Port = Convert.ToInt32(portNum),
                        State = state
                    }
                }.ToJson());

                var stateOut = state == true ? "HIGH" : "LOW";
                Console.WriteLine($"GPO Port: {portNum} - Set: {stateOut}");
                Console.WriteLine("---");
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }
        }

        await mqttClientService.Disconnect();
    }
}
catch (Exception ex)
{
    Console.WriteLine("Unexpected error occurred: " + ex.Message);
}
