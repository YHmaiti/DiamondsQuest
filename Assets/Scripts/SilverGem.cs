using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;

public class SilverGem : MonoBehaviour
{
    public GameObject Score;
    public AudioSource collectedGemSound;

    // so this will actually lead to the destruction of the collected
    // item after the player goes through it 
    // BUT -> need to check that for each collectable the trigger 
    //        checkbox is checked so the trigger is enabled
    void OnTriggerEnter()
    {
        Score.GetComponent<Text>().text = (int.Parse(Score.GetComponent<Text>().text) + 100).ToString();
        FixScoreHelperFile.scoreNow = int.Parse(Score.GetComponent<Text>().text);
        collectedGemSound.Play();
        Destroy(gameObject);
    }

}
