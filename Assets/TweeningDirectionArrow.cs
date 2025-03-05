using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TweeningDirectionArrow : MonoBehaviour
{
    public float moveDistance = 2f; // Distance to move up and down
    public float moveTime = 1f; // Time taken for one complete oscillation

    void Start()
    {
        // Initiate the oscillation
        LeanTween.moveLocalY(gameObject, transform.localPosition.y + moveDistance, moveTime)
                 .setLoopPingPong()
                 .setEase(LeanTweenType.easeInOutQuad);
    }
}
