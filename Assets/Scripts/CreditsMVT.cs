using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CreditsMVT : MonoBehaviour
{

    public GameObject creditsShow;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(PlayCredits());
    }

   IEnumerator PlayCredits()
    {
        yield return new WaitForSeconds(0.5f);
        creditsShow.SetActive(true);
        yield return new WaitForSeconds(15);
        SceneManager.LoadScene(1);
    }
}
