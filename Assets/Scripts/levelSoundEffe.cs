using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class levelSoundEffe : MonoBehaviour
{
    /*private static readonly string MusicPref = "MusicPref";
    private static readonly string SoundEffectsPref = "SoundEffectsPref";
    private float musicFloat, soundEffectsFloat;
    public AudioSource musicAudio;
    public AudioSource[] soundEffectsAudio;

    private void Awake()
    {
        levelSoundSettings();
    }

    private void levelSoundSettings()
    {
        musicFloat = PlayerPrefs.GetFloat(MusicPref);
        soundEffectsFloat = PlayerPrefs.GetFloat(SoundEffectsPref);

        musicAudio.volume = musicFloat;

        for (int i = 0; i < soundEffectsAudio.Length; i++)
        {
            soundEffectsAudio[i].volume = soundEffectsFloat;
        }
    */

     public AudioSource audio_;
     
     private void Start()
     {
         if (!PlayerPrefs.HasKey("volume")) audio_.volume = 1;
        

     }

     private void Update()
     {
         audio_.volume = PlayerPrefs.GetFloat("volume");
        

     }
     

    

    /*
    public string volumeParametr = "MasterVolume";
    public AudioMixer mixer;

    private void Start()
    {
        var volumeValue = PlayerPrefs.GetFloat(volumeParametr, volumeParametr == "MusicVol" ? 0f : -80f);
        mixer.SetFloat(volumeParametr, volumeValue);
    }
    */
}
