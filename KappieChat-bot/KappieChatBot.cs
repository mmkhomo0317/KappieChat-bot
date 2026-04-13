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
            Console.WriteLine("- How can I create a strong password?");
            Console.WriteLine("- What is phishing?");
            Console.WriteLine("- What is malware?");
            Console.WriteLine("- What is social engineering?");
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
                Console.WriteLine("Bot: Protecting computers, servers, mobile devices, electronic systems, networks, and data from malevolent attacks is known as cybersecurity." +
                    " Sensitive data is shielded from illegal access, data breaches," +
                    " and other cyberthreats by a variety of technologies, procedures, and practices.");
            }
            else if (input.Contains("scams"))
            {
                Console.WriteLine("Bot: A Scam is a dishonest or fraudulent scheme that attempts to take money or something of value from people. It is a confidence trick that dishonest groups," +
                    " individuals, or companies perform. The person who carries out a scam is a scammer, trickster, or swindler.");
            }
            else if (input.Contains("password"))
            {
                Console.WriteLine("Bot: For increased security, make sure your password is at least 12–16 characters long." +
                    "\r\n\r\nCombine capital and lowercase characters, numbers, and symbols (e.g., H3ll!).I@mJ0d1n3)." +
                    "\r\n\r\nDon't use private information like addresses, names, or birthdays." +
                    "\r\n\r\nCommon words, phrases, or keyboard patterns like \"password,\" \"1234,\" or \"qwerty\" should not be used." +
                    "\r\n\r\nCombine random, unrelated words to create a memorable passphrase (e.g., \"correct^Horse2Battery^Staple\")." +
                    "\r\n\r\nMake an acronym out of a memorable line (for example, \"I love ice cream every summer\" becomes Il!c3Ev$)." +
                    "\r\n\r\nDon't use the same password for several accounts." +
                    "\r\n\r\nTo create and safely store strong, one-of-a-kind passwords, think about utilizing a password manager.");
            }
            else if (input.Contains("phishing"))
            {
                Console.WriteLine("Bot: Phishing is a type of cyber attack where attackers impersonate legitimate organizations to steal sensitive information. Always be cautious of unsolicited emails and messages, and never click on suspicious links.",40);
            }
            else if (input.Contains("malware"))
            {
                Console.WriteLine("Bot: Malware is malicious software designed to harm or exploit any programmable device or network. It's important to keep your software updated and use reputable antivirus programs to protect against malware.");
            }
            else if (input.Contains("social engineering"))
                    {
                Console.WriteLine("Bot: Social engineering is a manipulation technique that exploits human error to gain private information, access, or valuables. Always be cautious of unsolicited requests for information and verify the identity of the requester.");
            }
            else if (input.Contains("thank you") || input.Contains("thanks"))
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
