using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KappieChat_bot
{
    public class User
    {
        public string Name { get; set; }
        public void GetUserName()
        {
            Console.WriteLine("Please enter your name:");
            Name = Console.ReadLine();
            
            while (string.IsNullOrWhiteSpace(Name))
            {
                Console.WriteLine("Name cannot be empty. Please enter your name:");
                Name = Console.ReadLine();
            }

            Console.WriteLine($"Welcome, {Name}! Let's start chatting.");
        }
    }
}
