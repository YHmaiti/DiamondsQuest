using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class deathDelimiter : MonoBehaviour
{
    public GameObject levelMusic;
    public GameObject youFell;
    public GameObject fadeOut;
    void OnTriggerEnter()
    {
        StartCoroutine(Falling());
    }

    // chose enumerator in this case 
    IEnumerator Falling()
    {
        youFell.SetActive(true);
        levelMusic.SetActive(false);
        yield return new WaitForSeconds(2);
        fadeOut.SetActive(true);
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene(2);
    }
}
