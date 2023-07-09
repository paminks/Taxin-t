using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class settings : MonoBehaviour
{
    private TMP_Dropdown dropdown;
    public AudioSource src;
    public AudioClip clip;


    List<int> widths = new List<int>() { 800, 1280, 1920 };
    List<int> heights= new List<int>() { 800, 1280, 1920 };



    public void SetScreenSize(int index)
    {
        bool fullscreen = Screen.fullScreen;
        int width = widths[index];
        int height = heights[index];
        Screen.SetResolution(width,height,fullscreen);

    }
    public void setfs(bool fullscreen)
    {
        Screen.fullScreen = fullscreen; ;
    }
    public void backtm()
    {
        src.clip = clip;
        src.Play();
        SceneManager.LoadScene("MainMenu");
    }
}
