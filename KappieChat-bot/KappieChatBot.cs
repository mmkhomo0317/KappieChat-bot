using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            Console.WriteLine();
            // Add chat logic here
        }
    }
}
