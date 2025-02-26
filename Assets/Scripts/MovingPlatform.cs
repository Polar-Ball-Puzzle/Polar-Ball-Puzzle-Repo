using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    public Transform up;
    public Transform down;


    float upLimit;
    float downLimit;
    public float speed;
    private int direction = 1;
    private Vector2 upDownmovement;
    
    
    // Start is called before the first frame update
    void Start()
    {
        upLimit = up.transform.position.y;
        downLimit = down.transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {

        if (transform.position.y > upLimit)
        {
            direction = -1;
        }
        else if (transform.position.y < downLimit)
        {
            direction = 1;
        }
        upDownmovement = Vector2.up * direction * speed * Time.deltaTime;

        transform.Translate(upDownmovement); 

       
    }
   


}
