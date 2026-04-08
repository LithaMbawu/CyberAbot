using System;

namespace Chatbot
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Chatbot is ready. Type something or 'exit' to quit.");
            string userInput;
            while ((userInput = Console.ReadLine()?.ToLower()) != "exit")
            {
                Console.WriteLine("You said: " + userInput);
                // Optional: Send a message to AudioPlayer terminal via file, socket, or IPC
            }
        }
    }
}

