using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
public class OptionsMenu : MonoBehaviour
{
    public AudioMixer audiomixer;
    public void setVolume(float volume)
    {
        audiomixer.SetFloat("volume", volume);
    }
    public void setQuality(int qualityIndex)
    {
        QualitySettings.SetQualityLevel(qualityIndex);
    }
    public void fullScrene(bool isFullscreen)
    {
        Screen.fullScreen = isFullscreen;
    }

}
