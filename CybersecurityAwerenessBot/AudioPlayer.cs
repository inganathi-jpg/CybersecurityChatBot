using System.Media;

namespace CybersecurityChatbot
{
    // Plays the voice greeting
    public class AudioPlayer
    {
        public void PlayGreeting()
        {
            try
            {
                // Path to WAV file
                SoundPlayer player =
                    new SoundPlayer("Assets/greeting.wav");

                player.Play();
            }
            catch
            {

            }
        }
    }
}