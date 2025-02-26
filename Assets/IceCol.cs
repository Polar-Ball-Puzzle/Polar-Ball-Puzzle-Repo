using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IceCol : MonoBehaviour
{
    public GameObject HitWorldEffect, Effect2;
   
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

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        float random = Random.Range(0, 360);
        if (collision.gameObject != false)
        {
            Instantiate(HitWorldEffect, transform.position,Quaternion.EulerRotation(0,0f,random));
           

        }
    }
}
