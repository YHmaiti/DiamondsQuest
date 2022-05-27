using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FixScoreHelperFile : MonoBehaviour
{

    [SerializeField] public static int scoreNow;
    public GameObject scoreBox;

    // Update is called once per frame
    void Update()
    {
        scoreBox.GetComponent<Text>().text = scoreNow.ToString();
    }
}
