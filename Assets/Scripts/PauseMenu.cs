using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public GameObject pausePanel;

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Pause(){
        pausePanel.SetActive(true);
        Time.timeScale = 0;
    }

    public void Unpause(){
        pausePanel.SetActive(false);
        Time.timeScale = 1.0f;
    }
}
