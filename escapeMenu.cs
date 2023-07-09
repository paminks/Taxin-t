using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class escapeMenu : MonoBehaviour
{
    public GameObject panel;
    public void openMenu()
    {
        panel.SetActive(true);
        Time.timeScale = 0f  ;
    }

    public void resumeGame()
    {
        panel.SetActive(false);
        Time.timeScale = 1f ;
    }
    public void ble()
    {
        SceneManager.LoadScene("MainMenu");
    }


    public float timeRemaining;
    public bool isRunning;
    public TMP_Text timeText;

    

    public void Start() 
    {
        

        Time.timeScale = 1f ;
        isRunning = true;


    }
    public GameObject timesup;
    public GameObject timesupbutton;
    private void Update()
    {
        if (isRunning)
        {
            if(timeRemaining >= 0f)
            {
                
                timeRemaining -= Time.deltaTime;
                timeText.text = timeRemaining.ToString();
            }
            if(timeRemaining < 0f) 
            {
                timeText.text = "0";
                Time.timeScale = 0f;
                timesup.SetActive(true);
                timesupbutton.SetActive(true);
                
                
            }
        }
    }

    public void retry()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    
}
