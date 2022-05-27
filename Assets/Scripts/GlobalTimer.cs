using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalTimer : MonoBehaviour
{
 
    public GameObject timer;
    public bool isTakingTime = false;
    public int seconds = 150;
    public static int extendedScoreForTheEnd;

    // Update is called once per frame
    void Update()
    {
        extendedScoreForTheEnd = seconds;
        if(isTakingTime == false)
        {
            StartCoroutine(SubtractSecond());
            //isTakingTime = true;
        }
    }

    IEnumerator SubtractSecond()
    {
        isTakingTime = true;
        seconds -= 1;
        timer.GetComponent<Text>().text = "" + seconds;
        yield return new WaitForSeconds(1); // stopping the code from running for 1sec
        isTakingTime = false;
    }
}
