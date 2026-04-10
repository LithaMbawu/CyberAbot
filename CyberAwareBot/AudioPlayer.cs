using System;
using System.Diagnostics;
using System.IO;

namespace CyberAwareBot
{
    public class AudioPlayer
    {
        public void PlayGreeting()
        {
            try
            {
                // Path to the greeting.wav in the project directory
                string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "greeting.wav");

                if (!File.Exists(filePath))
                {
                    Console.WriteLine("File not found: " + filePath);
                    return;
                }

                Console.WriteLine("Playing greeting...");

                // Mac audio playback
                Process.Start("afplay", $"\"{filePath}\"");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error playing greeting: " + ex.Message);
            }
        }
    }
}

