﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpringSwitch : MonoBehaviour
{
    public GameObject door;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ActivateDoor()
    {
        door.GetComponent<MovementScript>().Move();

    }
}
