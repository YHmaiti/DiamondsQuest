using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GemController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // can remain empty for now 
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 0.5f * Time.timeScale, 0, Space.World);
    }
}
