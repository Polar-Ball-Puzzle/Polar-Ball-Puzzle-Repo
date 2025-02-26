using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerTutorial : MonoBehaviour
{
    Rigidbody2D myRigidBody;
    public float speed = 10;
    public float jumpForce = 15;
    float moveinput;
    // Start is called before the first frame update
    void Start()
    {
        myRigidBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        moveinput = Input.GetAxis("Horizontal");
        myRigidBody.velocity = new Vector2(moveinput * speed, myRigidBody.velocity.y);

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            myRigidBody.velocity = Vector2.up * jumpForce;
        }
    }
}
