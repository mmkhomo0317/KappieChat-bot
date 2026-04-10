using System;
using System.Reflection.Metadata;

namespace KappieChat_bot
{
    class Program
    {
        static void Main(string[] args)
        {
            
            AudioPlayer.playGreeting();

            Chatbot.Displaylogo();

            UserStringHandle user = new User();
            user user = new user(); 
            user.GetUserName();

            Chatbot bot = new Chatbot(user);
            bot.StartChat();

            Console.ReadLine();
        }
    }
}

