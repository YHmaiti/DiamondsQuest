using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FinishLVL : MonoBehaviour
{
    public GameObject levelMusic;
    public AudioSource levelCompleted;
    public GameObject TimerGlobal;
    public GameObject LeftTime;
    public GameObject Score;
    public GameObject totalGameScore;
    public int timeElapsed;
    public int scoreCalculation1;
    public int totalScored;

    // add a variable here that will trigger the cubes I made to block the 
    // chan from moving after it has crossed the finish line 
    public GameObject CubeBlockTrigger;


    void OnTriggerEnter()
    {

        CubeBlockTrigger.SetActive(true);
        CubeBlockTrigger.transform.parent = null; // the cubes will no longer belong to the 
                                                    // character and they will be detached so she won't be able to move

        timeElapsed = GlobalTimer.extendedScoreForTheEnd * 100;
        string TempTimeLeft = "Time Left: " + GlobalTimer.extendedScoreForTheEnd + " * 100";
        LeftTime.GetComponent<Text>().text = TempTimeLeft;

        Score.GetComponent<Text>().text = "Score: " + FixScoreHelperFile.scoreNow;

        // addd the score to the time left (this will give us a new total score)
        // the user will be evaluated not only using the gems collected 
        // but also if they saved time in the process.
        totalScored = FixScoreHelperFile.scoreNow + timeElapsed;

        // update it in Unity 
        totalGameScore.GetComponent<Text>().text = "Total Score: " + totalScored;

        levelMusic.SetActive(false);// stop the ingame sound/ music
        TimerGlobal.SetActive(false);
        levelCompleted.Play();
        StartCoroutine(CalculateScore());
    }

    IEnumerator CalculateScore()
    {
        LeftTime.SetActive(true);
        yield return new WaitForSeconds(0.5f);
        Score.SetActive(true);
        yield return new WaitForSeconds(0.5f);
        totalGameScore.SetActive(true);
        yield return new WaitForSeconds(1);
    }
}
