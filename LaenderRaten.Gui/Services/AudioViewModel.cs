using LaenderRaten.Lib.Interfaces;
namespace LaenderRaten.Gui.Services;
using Plugin.Maui.Audio;

public class AudioViewModel(IAudioManager audioManager) : ISoundService
{
    readonly IAudioManager audioManager = audioManager;

    private IAudioPlayer currentAudioPlayer;

    public bool Mute;

    public async void PlayAudioCorrect()
    {
        if (Mute == false)
        {
            var audioPlayer = audioManager.CreatePlayer(await FileSystem.OpenAppPackageFileAsync("correct-answer.mp3"));

            audioPlayer.Volume = 1.5;

            currentAudioPlayer = audioPlayer;

            currentAudioPlayer.Play();
        }
        else
        {

        }

    }

    public async void MuteSound(bool mute)
    {
        Mute = mute;


        if (mute && currentAudioPlayer != null)
        {

            currentAudioPlayer.Volume = 0;
        }
        else if (!mute && currentAudioPlayer != null)
        {

            currentAudioPlayer.Volume = 1.5;
        }
    }

    public async void PlayAudioFail()
    {

        if (Mute == false)
        {
            var audioPlayer = audioManager.CreatePlayer(await FileSystem.OpenAppPackageFileAsync("wrong-answer.mp3"));

            audioPlayer.Volume = 1.5;

            currentAudioPlayer = audioPlayer;

            currentAudioPlayer.Play();

        }
        else if (Mute == true)
        {

        }


    }

}