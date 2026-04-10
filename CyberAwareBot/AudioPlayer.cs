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
                // Get Downloads folder
                string downloadsPath = Path.Combine(
                    Environment.GetFolderPath(Environment.SpecialFolder.UserProfile),
                    "Downloads",
                    "CyberAwareBot",
                    "greeting.wav"
                );

                if (!File.Exists(downloadsPath))
                {
                    Console.WriteLine("File not found: " + downloadsPath);
                    return;
                }

                Console.WriteLine("Playing greeting...");

                Process.Start(new ProcessStartInfo
                {
                    FileName = downloadsPath,
                    UseShellExecute = true
                });
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error playing greeting: " + ex.Message);
            }
        }
    }
}

