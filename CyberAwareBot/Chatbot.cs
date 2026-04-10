using System;

namespace CyberAwareBot
{
    public class Chatbot
    {
        private readonly string userName;

        public Chatbot(string name)
        {
            userName = string.IsNullOrWhiteSpace(name) ? "Guest" : name.Trim();
        }

        public void RunChat()
        {
            AudioPlayer audioPlayer = new AudioPlayer();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("-----------------------------------");
            Console.WriteLine($"   CYBER BOT CHAT - {userName.ToUpper()}");
            Console.WriteLine("-----------------------------------");
            Console.ResetColor();

            Console.WriteLine($"\nHi {userName}, ask me anything about cybersecurity!");
            Console.WriteLine("Type 'exit' to return to menu. Type 'play' to hear a greeting.\n");

            string input;

            while ((input = Console.ReadLine()?.ToLower()) != "exit")
            {
                if (string.IsNullOrWhiteSpace(input))
                {
                    Respond("I didn't quite understand that. Could you rephrase?", ConsoleColor.Red);
                }
                else if (input.Contains("how are you"))
                {
                    Respond("I'm running perfectly and ready to help you stay safe online!", ConsoleColor.Green);
                }
                else if (input.Contains("your purpose") || input.Contains("what do you do"))
                {
                    Respond("My purpose is to educate you on cybersecurity and help you stay safe online.", ConsoleColor.Green);
                }
                else if (input.Contains("what can i ask"))
                {
                    Respond("You can ask me about passwords, phishing, safe browsing, and general online safety.", ConsoleColor.Green);
                }
                else if (input.Contains("password"))
                {
                    Respond("Use strong, unique passwords with a mix of letters, numbers, and symbols.", ConsoleColor.Cyan);
                }
                else if (input.Contains("phishing"))
                {
                    Respond("Phishing is a scam where attackers trick you into giving personal info. Always verify links and emails.", ConsoleColor.Cyan);
                }
                else if (input.Contains("safe browsing") || input.Contains("browser"))
                {
                    Respond("Always use secure websites (HTTPS), avoid suspicious downloads, and keep your browser updated.", ConsoleColor.Cyan);
                }
                else if (input.Contains("play"))
                {
                    audioPlayer.PlayGreeting();
                }
                else
                {
                    Respond("I didn't quite understand that. Try asking about cybersecurity topics.", ConsoleColor.Red);
                }
            }
        }

        private void Respond(string message, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.WriteLine($"Bot: {message}");
            Console.ResetColor();
        }
    }
}

