using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GamePause: MonoBehaviour
{
    public bool gamePaused = false;
    public AudioSource levelMusic;
    public GameObject pauseMenu;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Cancel") && gamePaused == false)
        {
            Time.timeScale = 0; // set Unity to freeze everything and pause
            gamePaused = true;
            Cursor.visible = true;
            levelMusic.Pause();
            pauseMenu.SetActive(true);
        }

        // allow an undone type approach when the user clicks the esc button 
        // again 
        else if (Input.GetButtonDown("Cancel") && gamePaused == true)
        {
            Cursor.visible = false;
            gamePaused = false;
            Time.timeScale = 1;
            levelMusic.UnPause();
            pauseMenu.SetActive(false);

        }
        
    }
}
