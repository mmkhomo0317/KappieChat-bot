using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace KappieChat_bot
{
    public class KappieChatBot
    {
        private User user;

        public KappieChatBot(User user)
        {
            this.user = user;
        }

        public static void DisplayLogo()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(@"
______ __                      _____           ______________        _____       ______       _____ 
___  //_/_____ ___________________(_)____      __  ____/__  /_______ __  /_      ___  /_________  /_
__  ,<  _  __ `/__  __ \__  __ \_  /_  _ \     _  /    __  __ \  __ `/  __/________  __ \  __ \  __/
_  /| | / /_/ /__  /_/ /_  /_/ /  / /  __/     / /___  _  / / / /_/ // /_ _/_____/  /_/ / /_/ / /_  
/_/ |_| \__,_/ _  .___/_  .___//_/  \___/      \____/  /_/ /_/\__,_/ \__/        /_.___/\____/\__/  
               /_/     /_/                                                                          
                CYBER SECURITY BOT 
    ");
            // Add chat logic here
            Console.ResetColor();
        }

        public void StartChat()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("====================================================================================================================================");
            Console.WriteLine( $"Welcome {user.Name}! I'm Kappie, your cybersecurity bot. Ask me anything about cybersecurity, and I'll do my best to help you.");
            Console.WriteLine("====================================================================================================================================");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\nAvailable Questions: ");
            Console.WriteLine("- What is cybersecurity?");
            Console.WriteLine("- How can I create a strong password?");
            Console.WriteLine("- What is phishing?");
            Console.WriteLine("- What is malware?");
            Console.WriteLine("- What is ransomware?");
            Console.WriteLine("- What is two-factor authentication (2FA)?");
            Console.WriteLine("- Thank you! to quit");
            Console.ResetColor();

            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("\nYou: ");
                Console.ResetColor();

                string input = Console.ReadLine()?.ToLower();

                if (string.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("Bot: Please enter something.");
                    continue;
                }

                // Process user input and generate a response
                if (input.Contains("exit"))
                {
                    Console.WriteLine("Bot: Goodbye!");
                    break;
                }

                Respond(input);
            }
        }

        private void Respond(string input)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Bot: ");

            // Simple response logic for demonstration
            if (input.Contains("hello") || input.Contains("hi"))
            {
                Console.WriteLine("Bot: Hello! How can I help you today?");
            }
            else if (input.Contains("cybersecurity"))
            {
                Console.WriteLine("Bot: Cybersecurity is the practice of protecting systems, networks, and programs from digital attacks. Do you have any specific questions about it?");
            }
            else if (input.Contains("Scams"))
            {
                Console.WriteLine("Bot: Scams are fraudulent schemes designed to deceive people. Always be cautious of unsolicited messages and offers that seem too good to be true.");
            }
            else if (input.Contains("Password"))
            {
                Console.WriteLine("Bot: A strong password should be at least 12 characters long and include a mix of letters, numbers, and special characters. Do you want tips on creating a strong password?");
            }
            else if (input.Contains("phishing"))
            {
                Console.WriteLine("Bot: Phishing is a type of cyber attack where attackers impersonate legitimate organizations to steal sensitive information. Always be cautious of unsolicited emails and messages, and never click on suspicious links.",40);
            }
            else if (input.Contains("malware"))
            {
                Console.WriteLine("Bot: Malware is malicious software designed to harm or exploit any programmable device or network. It's important to keep your software updated and use reputable antivirus programs to protect against malware.");
            }
            else if (input.Contains("ransomware"))
            {
                Console.WriteLine("Bot: Ransomware is a type of malware that encrypts a victim's files and demands payment to restore access. Always back up your data regularly and be cautious of email attachments and links to avoid ransomware attacks.");
            }
            else if (input.Contains("two-factor authentication") || input.Contains("2fa"))
            {
                Console.WriteLine("Bot: Two-factor authentication (2FA) adds an extra layer of security to your accounts by requiring a second form of verification, such as a code sent to your phone. It's highly recommended to enable 2FA on all your important accounts.");
            }
            else if (input.Contains("Social Engineering"))
                    {
                Console.WriteLine("Bot: Social engineering is a manipulation technique that exploits human error to gain private information, access, or valuables. Always be cautious of unsolicited requests for information and verify the identity of the requester.");
            }
            else if (input.Contains("Thank you") || input.Contains("Thanks"))
            {
                Console.WriteLine("Bot: You're welcome! If you have any more questions, feel free to ask.");
            }
            else
            {
                Console.WriteLine("Bot: I'm not sure how to respond to that. Can you please rephrase?");
            }

            Console.ResetColor();
        }

        private void TypeEffect(String message)
        {
            foreach (char c in message)
            {
                Console.Write(c);
                System.Threading.Thread.Sleep(50); // Adjust the delay as needed
            }
            Console.WriteLine();
        }
    }
}
