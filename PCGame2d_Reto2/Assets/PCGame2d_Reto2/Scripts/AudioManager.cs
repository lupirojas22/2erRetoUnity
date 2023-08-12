using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AudioManager : MonoBehaviour
{
   
    public AudioSource audioSource;

    public Image soundButtonImage;
    public Sprite soundOnSprite;
    public Sprite soundOffSprite;



     //pausar music
    public void ToggleMusic()
    {
        if (audioSource.isPlaying)
        {

            audioSource.Pause();
            soundButtonImage.sprite = soundOffSprite;
        }
        else
        {
            audioSource.UnPause();
            soundButtonImage.sprite = soundOnSprite;
        }
    }


    public void ChangeVolume(float newVolume)
    {
        if (audioSource != null)
        {
            // Cambia el volumen del AudioSource según el valor del Slider
            audioSource.volume = newVolume;
        }
    }

}
