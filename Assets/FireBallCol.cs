using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBallCol : MonoBehaviour
{
    public GameObject HitWorldEffect,Effect2;
    public int random;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
         random = Random.Range(0, 1);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
       
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject != false)
        {

            if (random == 0)
            {
                Instantiate(HitWorldEffect, transform.position, Quaternion.identity);
            }
            else
            if (random == 1)
            {
                Instantiate(Effect2, transform.position, Quaternion.identity);
            }

        }
        //if (collision.gameObject.name=="Obstacle") // temporary fix
        //{
        //    Destroy(collision.gameObject);
        //}
    }
}
