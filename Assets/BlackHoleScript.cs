﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlackHoleScript : MonoBehaviour
{
    public GameObject collisioneffect;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Black")
        {
            Destroy(collision.gameObject);
            Instantiate(collisioneffect, transform.position, Quaternion.identity);
           
        }

        if (collision.gameObject.name == "Obstacle") // temporary fix
        {
            Destroy(collision.gameObject);
        }
    }
}
