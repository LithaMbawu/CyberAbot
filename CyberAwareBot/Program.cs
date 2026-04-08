using System;

namespace CybersecurityBot
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Cybersecurity Bot!");
            bool running = true;

            while (running)
            {
                // Display menu
                Console.WriteLine("\nPlease select a topic:");
                Console.WriteLine("1. Password Safety");
                Console.WriteLine("2. Phishing");
                Console.WriteLine("3. Safe Browsing");
                Console.WriteLine("4. Exit");

                Console.Write("Enter your choice (1-4): ");
                string choice = Console.ReadLine();

                switch (choice.Trim())
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
                        Console.WriteLine("Goodbye! Stay safe online.");
                        running = false;
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please select 1-4.");
                        break;
                }
            }
        }

        static void RunTopic(string topic, string[] questions)
        {
            Console.WriteLine($"\n--- {topic} Questions ---");

            for (int i = 0; i < questions.Length; i++)
            {
                // Number each question
                Console.WriteLine($"\n{i + 1}. {questions[i]}");
                Console.Write("Your answer: ");
                string userAnswer = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(userAnswer))
                    Console.WriteLine("Bot: I didn't quite understand that. Could you rephrase?");
                else
                    Console.WriteLine("Bot: Thanks for your answer!");
            }

            Console.WriteLine($"\nYou have completed the {topic} questions!");
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

