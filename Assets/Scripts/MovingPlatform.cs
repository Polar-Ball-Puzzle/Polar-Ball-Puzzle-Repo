using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    //public Transform up;
    //public Transform down;


    //float upLimit;
    //float downLimit;
    //public float speed;
    //private int direction = 1;
    //private Vector2 upDownmovement;


    //// Start is called before the first frame update
    //void Start()
    //{
    //    upLimit = up.transform.position.y;
    //    downLimit = down.transform.position.y;
    //}

    //// Update is called once per frame
    //void Update()
    //{

    //    if (transform.position.y > upLimit)
    //    {
    //        direction = -1;
    //    }
    //    else if (transform.position.y < downLimit)
    //    {
    //        direction = 1;
    //    }
    //    upDownmovement = Vector2.up * direction * speed * Time.deltaTime;

    //    transform.Translate(upDownmovement);


    //}



    public enum MovementType
    {
        Vertical,
        Horizontal,
        Both
    }

    public MovementType movementType = MovementType.Both;

    [Header("Vertical Boundaries (Used for Vertical & Both)")]
    public Transform up;
    public Transform down;

    [Header("Horizontal Boundaries (Used for Horizontal & Both)")]
    public Transform left;
    public Transform right;

    public float speed = 2f;

    private float upLimit;
    private float downLimit;
    private float leftLimit;
    private float rightLimit;

    // Direction multipliers
    private int verticalDirection = 1;   // 1 = moving up, -1 = moving down
    private int horizontalDirection = 1; // 1 = moving right, -1 = moving left

    void Start()
    {
        // Set boundaries if needed based on the movement type
        if (movementType == MovementType.Vertical || movementType == MovementType.Both)
        {
            if (up != null && down != null)
            {
                upLimit = up.position.y;
                downLimit = down.position.y;
            }
            else
            {
                Debug.LogWarning("Vertical boundaries are not assigned!");
            }
        }

        if (movementType == MovementType.Horizontal || movementType == MovementType.Both)
        {
            if (left != null && right != null)
            {
                leftLimit = left.position.x;
                rightLimit = right.position.x;
            }
            else
            {
                Debug.LogWarning("Horizontal boundaries are not assigned!");
            }
        }
    }

    void Update()
    {
        Vector2 movement = Vector2.zero;

        // Vertical movement
        if (movementType == MovementType.Vertical || movementType == MovementType.Both)
        {
            if (transform.position.y > upLimit)
            {
                verticalDirection = -1;
            }
            else if (transform.position.y < downLimit)
            {
                verticalDirection = 1;
            }
            movement.y = verticalDirection;
        }

        // Horizontal movement
        if (movementType == MovementType.Horizontal || movementType == MovementType.Both)
        {
            if (transform.position.x > rightLimit)
            {
                horizontalDirection = -1;
            }
            else if (transform.position.x < leftLimit)
            {
                horizontalDirection = 1;
            }
            movement.x = horizontalDirection;
        }

        // Apply movement
        transform.Translate(movement * speed * Time.deltaTime);
    }

} 

