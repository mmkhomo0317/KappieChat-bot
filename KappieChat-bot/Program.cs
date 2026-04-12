using System;
using System.Reflection.Metadata;

namespace KappieChat_bot
{
    class Program
    {
        static void Main(string[] args)
        {
            AudioPayer.PlayGreeting();
            KappieChatBot.DisplayLogo();
            User user = new User(); 
            user.GetUserName();
            KappieChatBot bot = new KappieChatBot(user);
            bot.StartChat();
            Console.ReadLine();
        }
    }
}

