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
        
        static SoundPlayer AttackSoundPlayer = new SoundPlayer(@"C:\Users\Arno\Desktop\DeveloperADJ\week-05\Wanderer Game\Wanderer Game\Wanderer Game\Assets\Sound\386862__freezefast65__8-bit-explosion.wav");

        public static void PlayMusic()
        {
            musicPlayer.Open(new Uri(@"C:\Users\Arno\Desktop\DeveloperADJ\week-05\Wanderer Game\Wanderer Game\Wanderer Game\Assets\Sound\273539__tristan-lohengrin__8bit-introduction.wav"));
            musicPlayer.Play();
        }

        public static void PlaySoundEffect()
        {
            AttackSoundPlayer.Play();
        }

    }
}
