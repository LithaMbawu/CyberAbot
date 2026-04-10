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
                string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "greeting.wav");

                if (!File.Exists(filePath))
                {
                    Console.WriteLine("File not found: " + filePath);
                    return;
                }

                Console.WriteLine("Playing greeting...");

                Process.Start(new ProcessStartInfo
                {
                    FileName = "afplay",
                    Arguments = $"\"{filePath}\"",
                    UseShellExecute = false,
                    CreateNoWindow = true
                });
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error playing greeting: " + ex.Message);
            }
        }
    }
}

