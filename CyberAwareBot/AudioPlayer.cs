using System;
using System.Media;

namespace AudioPlayer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Audio Player is ready. Type 'play' to play greeting or 'exit' to quit.");

            string input;
            while ((input = Console.ReadLine()?.ToLower()) != "exit")
            {
                if (input == "play")
                {
                    PlayGreeting();
                }
                else
                {
                    Console.WriteLine("Unknown command. Use 'play' or 'exit'.");
                }
            }
        }

        static void PlayGreeting()
        {
            try
            {
                SoundPlayer player = new SoundPlayer("greeting.wav");
                player.Load();
                player.PlaySync();
                Console.WriteLine("Greeting finished playing.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error playing greeting: " + ex.Message);
            }
        }
    }
}


