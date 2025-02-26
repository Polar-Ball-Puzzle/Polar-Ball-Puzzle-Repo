﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class JoystickSizeMonitor : MonoBehaviour
{
    public Slider joystickSlider;
    // Start is called before the first frame update
    void Start()
    {
        if (joystickSlider.value <= 0.001)
        {
            joystickSlider.value = 0.22f;
        }
        else
        {
            this.gameObject.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (joystickSlider.value <= 0.001)
        {
            joystickSlider.value = 0.22f;
        }
        else
        {
            this.gameObject.SetActive(false);
        }
    }
}
