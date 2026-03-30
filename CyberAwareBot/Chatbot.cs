using System;
using System.Media; // Needed for SoundPlayer

namespace CybersecurityBot
{
    class Program
    {
        static void Main(string[] args)
        {
            PlayGreeting();

            // Your chatbot logic here
            Console.WriteLine("Chatbot is ready. How can I help you today?");
            // Example: Wait for user input
            string userInput = Console.ReadLine();
            Console.WriteLine("You said: " + userInput);
        }

        static void PlayGreeting()
        {
            try
            {
                SoundPlayer player = new SoundPlayer("greeting.wav"); // Make sure file path is correct
                player.Load(); // Optional: load synchronously before playing
                player.PlaySync(); // PlaySync ensures greeting finishes before continuing
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error playing greeting: " + ex.Message);
            }
        }
    }
}


