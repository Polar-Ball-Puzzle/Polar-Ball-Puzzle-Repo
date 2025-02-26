using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleScript : MonoBehaviour
{
    Rigidbody2D myRigidbody;
    float PlayerXPosition;
    bool isScoreAdded;
    public float Velocity;
    GameManagerScript GameManager;

    // Start is called before the first frame update
    void Start()
    {
        myRigidbody = gameObject.GetComponent<Rigidbody2D>();
        myRigidbody.velocity = new Vector2(-Velocity, 0);
        PlayerXPosition = GameObject.Find("Player").transform.position.x;
        isScoreAdded = false;
        GameManager = GameObject.Find("Gamemanager").GetComponent<GameManagerScript>();
    }

    // Update is called once per frame
    void Update()
    {
       
        if (transform.position.x <= PlayerXPosition)
        {
           
            if (!isScoreAdded)
            {
                AddScore();
                isScoreAdded = true;
            }
        }
        if (transform.position.x <= -15.6f)
        {
            Destroy(gameObject);

        }
       
    }
    void AddScore()
    {
        GameManager.GmAddScore();
    }
}
