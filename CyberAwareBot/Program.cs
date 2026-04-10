using System;

namespace CyberAwareBot
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Cybersecurity Awareness Bot";

            AudioPlayer audioPlayer = new AudioPlayer();
            audioPlayer.PlayGreeting();

            UIHelper ui = new UIHelper();
            Console.WriteLine();
            ui.ShowBanner();

            string userName = PromptForUserName();
            ui.ShowWelcome(userName);

            bool running = true;
            Chatbot chatbot = new Chatbot(userName);

            while (running)
            {
                ShowMenu();
                Console.Write("Enter your choice (1-6): ");
                string choice = (Console.ReadLine() ?? string.Empty).Trim();

                switch (choice)
                {
                    case "1":
                        RunTopic("Password Safety", GetPasswordQuestions());
                        break;
                    case "2":
                        RunTopic("Phishing", GetPhishingQuestions());
                        break;
                    case "3":
                        RunTopic("Safe Browsing", GetBrowsingQuestions());
                        break;
                    case "4":
                        chatbot.RunChat();
                        break;
                    case "5":
                        audioPlayer.PlayGreeting();
                        break;
                    case "6":
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("\nGoodbye, {0}! Stay safe online.", userName);
                        Console.ResetColor();
                        running = false;
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Invalid choice. Please select 1-6.");
                        Console.ResetColor();
                        break;
                }
            }
        }

        static string PromptForUserName()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Please enter your name: ");
            string name = Console.ReadLine()?.Trim();
            Console.ResetColor();

            if (string.IsNullOrWhiteSpace(name))
            {
                name = "Guest";
            }

            return name;
        }

        static void ShowMenu()
        {
            Console.WriteLine("\n────────────────────────────────────────────────");
            Console.WriteLine("|           Cybersecurity Awareness Menu         |");
            Console.WriteLine("────────────────────────────────────────────────");
            Console.WriteLine("1. Password Safety");
            Console.WriteLine("2. Phishing");
            Console.WriteLine("3. Safe Browsing");
            Console.WriteLine("4. Chat with Bot");
            Console.WriteLine("5. Play Greeting");
            Console.WriteLine("6. Exit");
        }

        static void RunTopic(string topic, string[] questions)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"\n--- {topic} Questions ---");
            Console.ResetColor();

            for (int i = 0; i < questions.Length; i++)
            {
                Console.WriteLine($"\n{i + 1}. {questions[i]}");
                Console.Write("Your answer: ");
                string userAnswer = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(userAnswer))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Bot: I didn't quite understand that. Could you rephrase?");
                    Console.ResetColor();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Bot: That is a thoughtful answer. Keep going!");
                    Console.ResetColor();
                }
            }

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"\nYou have completed the {topic} questions!");
            Console.ResetColor();
        }

        static string[] GetPasswordQuestions()
        {
            return new string[]
            {
                "Why is it important to have a strong password?",
                "Should you use the same password for multiple accounts?",
                "What makes a password strong?",
                "How often should you change your passwords?",
                "What is a password manager and why use one?",
                "Is using personal info in your password safe?",
                "What is two-factor authentication (2FA)?",
                "How can you safely store your passwords?"
            };
        }

        static string[] GetPhishingQuestions()
        {
            return new string[]
            {
                "What is phishing?",
                "How can you recognize a phishing email?",
                "Why should you avoid clicking unknown links?",
                "What should you do if you suspect a phishing attempt?",
                "Is it safe to reply to suspicious emails?",
                "What is spear phishing?",
                "How do phishing scams affect businesses?",
                "Can phishing happen over phone calls (vishing)?"
            };
        }

        static string[] GetBrowsingQuestions()
        {
            return new string[]
            {
                "What is a secure website?",
                "Why is HTTPS important?",
                "What are the risks of using public Wi-Fi?",
                "Why should your browser be updated regularly?",
                "What is safe downloading practice?",
                "How can you check website credibility?",
                "Why should you avoid unknown pop-ups?",
                "What is browser sandboxing and why does it help?"
            };
        }
    }
}

