using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;


public class MainMenu : MonoBehaviour
{
   public void PlayGame ()
   {
    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    Debug.Log("Masuk Game Scene");
   }

    public void OptionGame ()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
        Debug.Log("Masuk Option Game");
    }



    public void QuitGame ()
    {

    #if    UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;

    #else
            Application.QuitGame ();
    
    #endif
    
    }

    public void SetQuality (int qualityIndex)
    {
        QualitySettings.SetQualityLevel(qualityIndex);
        
    }

    public void SetFullscreen (bool isFullscreen)
    {
        Screen.fullScreen = isFullscreen;
    }
}

