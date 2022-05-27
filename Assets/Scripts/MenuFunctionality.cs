using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuFunctionality : MonoBehaviour
{

    public AudioSource ButtonPressed;

    // addd a method for playing the game (launch the game)
    // the button requires having a public method 
    public void PlayGame()
    {
        ButtonPressed.Play();
        ResetLevel.reloadLvl = 3;
        SceneManager.LoadScene(2);
    }

    // have somthing to link to the exit button here
    // but this will only work when the exe is ready 
    // the engine testing it won't work :( 
    public void StopAndExit()
    {
        Application.Quit();
    }

    public void CredsShowNow()
    {
        ButtonPressed.Play();
        SceneManager.LoadScene(4);
    }
}
