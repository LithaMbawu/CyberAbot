using System;
using System.Threading;

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
            Console.WriteLine("\n===========================================");
            Console.WriteLine($"    CYBER BOT CHAT SESSION - {userName.ToUpper()}");
            Console.WriteLine("===========================================");
            Console.ResetColor();

            TypeText($"Hi {userName}, I'm here to answer your cybersecurity questions.\n", ConsoleColor.Green);
            TypeText("You can ask about passwords, phishing, browser safety, or say 'play' to hear the greeting again.\n", ConsoleColor.DarkCyan);
            TypeText("Type 'exit' to return to the main menu.\n\n", ConsoleColor.Green);

            string input;

            while ((input = (Console.ReadLine() ?? string.Empty).Trim().ToLower()) != "exit")
            {
                if (string.IsNullOrWhiteSpace(input))
                {
                    Respond("I didn't quite understand that. Could you rephrase?", ConsoleColor.Red);
                }
                else if (input.Contains("how are you"))
                {
                    Respond("I'm operating smoothly and ready to help you stay secure.", ConsoleColor.Green);
                }
                else if (input.Contains("your purpose") || input.Contains("what do you do"))
                {
                    Respond("My purpose is to guide you through cybersecurity best practices and keep you aware of online risks.", ConsoleColor.Green);
                }
                else if (input.Contains("what can i ask") || input.Contains("what can i say"))
                {
                    Respond("Ask me about passwords, phishing, safe browsing, multi-factor authentication, and general online safety.", ConsoleColor.Green);
                }
                else if (input.Contains("password"))
                {
                    Respond("Strong passwords should be unique, long, and include letters, numbers, and symbols. Avoid reuse.", ConsoleColor.Cyan);
                }
                else if (input.Contains("phishing"))
                {
                    Respond("Phishing is when attackers trick you via email, messages, or sites. Always verify the sender and never click suspicious links.", ConsoleColor.Cyan);
                }
                else if (input.Contains("safe browsing") || input.Contains("browser") || input.Contains("https"))
                {
                    Respond("Use HTTPS sites, keep your browser updated, and avoid unknown downloads or suspicious pop-ups.", ConsoleColor.Cyan);
                }
                else if (input.Contains("two-factor") || input.Contains("2fa") || input.Contains("multi-factor"))
                {
                    Respond("Two-factor authentication adds a second layer of security, which makes it much harder for attackers to access your account.", ConsoleColor.Cyan);
                }
                else if (input.Contains("play"))
                {
                    TypeText("Playing the voice greeting again for you...\n", ConsoleColor.Magenta);
                    audioPlayer.PlayGreeting();
                }
                else if (input.Contains("thank"))
                {
                    Respond("You're welcome! If you have more questions, I'm here to help.", ConsoleColor.Green);
                }
                else
                {
                    Respond("That is a great question. Try asking about passwords, phishing, or safe browsing.", ConsoleColor.Red);
                }
            }

            Console.WriteLine();
        }

        private void Respond(string message, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.WriteLine($"Bot: {message}");
            Console.ResetColor();
        }

        private void TypeText(string text, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            foreach (char character in text)
            {
                Console.Write(character);
                Thread.Sleep(12);
            }
            Console.ResetColor();
        }
    }
}

