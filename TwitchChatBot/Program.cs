using System;
using System.Threading;
using TwitchChat.Bot.Core;

namespace TwitchChatBot
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Initiating ChatBot...");
            Console.WriteLine("To exit, close window or press Ctrl+C");

            var automatedMessagingSystem = new AutomatedMessagingSystem();

            var intervalTriggeredMessage = new IntervalTriggeredMessage()
            {
                DelayInMinutes = 1,
                Message = "Hello, everyone! I am the bot!"
            };

            while (true)
            {
                Thread.Sleep(1000);

                automatedMessagingSystem.CheckMessages(DateTime.Now);

                while (automatedMessagingSystem.DequeueMessage(out string theMessage))
                {
                    Console.WriteLine($"{DateTime.Now.ToShortTimeString()} - {theMessage}");
                }
            }

        }
    }
}
