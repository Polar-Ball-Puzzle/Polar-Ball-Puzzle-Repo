using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttemptsSetter : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.SetInt("Attempts", 1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
