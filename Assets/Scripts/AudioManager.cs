using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class AudioManager : MonoBehaviour
{
    [SerializeField]
    private AudioSource _laserSound;
    [SerializeField]
    private AudioSource _explosion;
    [SerializeField]
    private AudioSource _powerUp;
    [SerializeField]
    private AudioMixer MyMixer;
    [SerializeField]
    private Slider MusicMixer;
    [SerializeField]
    private AudioSource _backGround;
    public void PlayLaserSound()
    {
        _laserSound.Play();
    }
    public void PlayBackGroundSound()
    {
        _backGround.Play();
    }

    public void PlayExplosionSound()
    {
        _explosion.Play();
    }

    public void PlayPowerUpSound()
    {
        _powerUp.Play();
    }
    private void Start()
    {
        if(PlayerPrefs.HasKey("VolumeVolume"))
        {
            LoadVolume();
        }
        else
        {
            setVolume();
        }
        

    }
    public void setVolume()
    {
        float volume = MusicMixer.value;
        MyMixer.SetFloat("Volume", Mathf.Log10(volume) * 20);
        PlayerPrefs.SetFloat("VolumeVolume", volume);
    }
    private void LoadVolume()
    {
        MusicMixer.value = PlayerPrefs.GetFloat("VolumeVolume");
        setVolume();
    }
}
