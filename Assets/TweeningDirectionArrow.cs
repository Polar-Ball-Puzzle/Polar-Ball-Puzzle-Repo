using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TweeningDirectionArrow : MonoBehaviour
{
    public enum Direction
    {
        UpDown, // Move along the Y-axis
        LeftRight // Move along the X-axis
    }

    public Direction moveDirection = Direction.UpDown; // Direction to move in
    public float moveDistance = 2f; // Distance to move
    public float moveTime = 1f; // Time taken for one complete oscillation

    void Start()
    {
        Vector3 targetPosition = transform.localPosition;

        // Determine the target position based on the selected direction
        if (moveDirection == Direction.UpDown)
        {
            targetPosition.y += moveDistance;
            LeanTween.moveLocalY(gameObject, targetPosition.y, moveTime)
                     .setLoopPingPong()
                     .setEase(LeanTweenType.easeInOutQuad);
        }
        else if (moveDirection == Direction.LeftRight)
        {
            targetPosition.x += moveDistance;
            LeanTween.moveLocalX(gameObject, targetPosition.x, moveTime)
                     .setLoopPingPong()
                     .setEase(LeanTweenType.easeInOutQuad);
        }
    }
}
