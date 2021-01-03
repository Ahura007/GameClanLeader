using System;

namespace App.Service.Voice
{
    public class Voice
    {
        public static void PlaySound(string path)
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(Environment.CurrentDirectory + path);
            player.Load();
            player.Play();
        }
    }
}