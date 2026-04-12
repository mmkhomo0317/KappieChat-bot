using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace KappieChat_bot
{
    public static class AudioPayer
    {
        public static void PlayGreeting()
        {
            string Path = "greeting.wav"; // Ensure this file exists in the correct path
            
            if (File.Exists(Path)) 
            {
                SoundPlayer player = new SoundPlayer(Path);
                player.Play();
            }
        }
    }
}
