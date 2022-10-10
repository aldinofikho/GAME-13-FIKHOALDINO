using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;
using UnityEngine.UI;

public class Options : MonoBehaviour
{


    [SerializeField] Slider Slider_volume;
    public AudioMixer audioMixer;

    private void Start()
    {
        float db;

        audioMixer.GetFloat("BGM_vol", out db);
        Slider_volume.value = (db + 80) / 80;
    }


    public void OptionGame ()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
    }

    public void BackGame ()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 2);
        Debug.Log("back Menu");
    }

    public void SetVolume(float volume)
    {
        volume = volume *80 - 80;
        audioMixer.SetFloat("BGM_vol", volume);
        Debug.Log("Musik volume sebesar" + volume);

    }
   
    public void SetQuality (int qualityIndex)
    {
        QualitySettings.SetQualityLevel(qualityIndex);
    }


    List<int> widths = new List<int>() {568, 960, 1280, 1920};
    List<int> heights = new List<int>() {329, 540, 800, 1080};
    
    public void SetScreenSize (int index)
    {
        bool fullScreen = Screen.fullScreen;
        int width = widths[index];
        int height = heights[index];
        
        Screen.SetResolution(width, height, fullScreen);

    }

    public void SetFullscreen (bool _fullscreen)
    {
        Screen.fullScreen = _fullscreen;
    }

    public void MuteToggle(bool muted)
    {
        if (muted)
        {
            AudioListener.volume = 0;
            Debug.Log("Musik off");
        }
        else
        {
            AudioListener.volume = 1;
            Debug.Log("Musik on");
        }

    }
}
