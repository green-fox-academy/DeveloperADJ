using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace Wanderer_Game.Model
{
    public static class Sound
    {
        static MediaPlayer musicPlayer = new MediaPlayer();
        
        static MediaPlayer effectsPlayer = new MediaPlayer();

        public static void PlayMusic(string musicFile)
        {
            musicPlayer.Open(new Uri(musicFile));
            musicPlayer.Play();
        }

        public static void PlaySoundEffect(string soundFile)
        {
            effectsPlayer.Open(new Uri(soundFile));
            effectsPlayer.Play();
        }
    }
}
