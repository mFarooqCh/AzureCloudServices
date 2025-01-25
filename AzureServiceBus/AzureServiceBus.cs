using Azure.Messaging.ServiceBus;

namespace Starter
{
    internal class AzureServiceBus
    {
        private readonly string _connectionString;
        private readonly ServiceBusClient _serviceBusClient;
        private readonly string queueName;
        public AzureServiceBus(string connectionString, string queuename)
        {
            _serviceBusClient = new ServiceBusClient(connectionString);
            _connectionString = connectionString;
            queueName = queuename;
        }

        public async Task SendMessageAsync()
        {
            // Create a ServiceBusSender object by invoking the CreateSender method on the ServiceBusClient object, and specifying the queue name. 
            ServiceBusSender sender = _serviceBusClient.CreateSender(queueName);

            // Create a new message to send to the queue.
            string messageContent = "Order new crankshaft for eBike.";
            var message = new ServiceBusMessage(messageContent);

            // Send the message to the queue.
            await sender.SendMessageAsync(message);
        }

        public async Task ReceiveMessageAsync()
        {
            // Create a ServiceBusSender object by invoking the CreateSender method on the ServiceBusClient object, and specifying the queue name. 
            ServiceBusReceiver receiver = _serviceBusClient.CreateReceiver(queueName);

            // Send the message to the queue.
            await receiver.ReceiveMessagesAsync(1, TimeSpan.FromSeconds(1));
        }
    }
}
