using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CreditSceneToMenu : MonoBehaviour
{
    public GameObject logoUnityChan;

    void Start()
    {

        StartCoroutine(CreditScreenBehaviour());
        
    }

    IEnumerator CreditScreenBehaviour()
    {
        yield return new WaitForSeconds(0.5f);
        logoUnityChan.SetActive(true);
        yield return new WaitForSeconds(4.5f);
        SceneManager.LoadScene(1);

    }

  
}
