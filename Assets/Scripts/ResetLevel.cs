using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ResetLevel : MonoBehaviour
{

    public static int reloadLvl; // keeping it one just for now as I only made one scene (level)

    // Update is called once per frame
    void Update()
    {
        if(reloadLvl == 3) // this will make more sense later when more scenes will be available 
        {
            SceneManager.LoadScene(reloadLvl);
        }
    }
}
