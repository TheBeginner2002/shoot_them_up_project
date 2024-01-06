using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class AudioManager : MonoBehaviour
{
    [Header("----- Audio Source -----")]
    [SerializeField] AudioSource musicSource;
    [SerializeField] AudioSource SFXSource;

    [Header("----- Audio Clip -----")]
    public AudioClip shootSound;
    public AudioClip rocketSound;
    public AudioClip explosion;
    public AudioClip background;

    [SerializeField]
    private AudioMixer MyMixer;
    [SerializeField]
    private Slider SoundMixer;
    [SerializeField]
    private Slider MusicMixer;
    [SerializeField]
    private Slider SFXMixer;

    private void Start()
    {
        musicSource.clip = background;
        musicSource.Play();
        if (PlayerPrefs.HasKey("VolumeVolume"))
        {
            LoadVolume();
        }
        else
        {
            setVolume();
            setMusic();
            setSFX();
        }
    }

    public void playSFX(AudioClip clip)
    {
        SFXSource.PlayOneShot(clip);
    }
    public void setVolume()
    {
        float volume = SoundMixer.value;
        MyMixer.SetFloat("Volume", Mathf.Log10(volume) * 20);
        PlayerPrefs.SetFloat("VolumeVolume", volume);
    }
    public void setMusic()
    {
        float volume = MusicMixer.value;
        MyMixer.SetFloat("Music", Mathf.Log10(volume) * 20);
        PlayerPrefs.SetFloat("MusicVolume", volume);
    }
    public void setSFX()
    {
        float volume = SFXMixer.value;
        MyMixer.SetFloat("SFX", Mathf.Log10(volume) * 20);
        PlayerPrefs.SetFloat("SFXVolume", volume);
    }
    private void LoadVolume()
    {
        SoundMixer.value = PlayerPrefs.GetFloat("VolumeVolume");
        SoundMixer.value = PlayerPrefs.GetFloat("MusicVolume");
        SoundMixer.value = PlayerPrefs.GetFloat("SFXVolume");
        setVolume();
        setMusic();
        setSFX();
    }
}
