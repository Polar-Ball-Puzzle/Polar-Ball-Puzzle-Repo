using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RopeSwinging : MonoBehaviour
{
    public DistanceJoint2D distanceJoint;
    public GameObject ropeSegmentPrefab;
    public int numberOfSegments = 5;
    public float swingAmplitude = 0.1f;
    public float swingFrequency = 1.0f;

    private GameObject[] ropeSegments;

    void Start()
    {
        ropeSegments = new GameObject[numberOfSegments];
        for (int i = 0; i < numberOfSegments; i++)
        {
            ropeSegments[i] = Instantiate(ropeSegmentPrefab, transform.position, Quaternion.identity);
        }
    }

    void Update()
    {
        Vector2 jointPosition = distanceJoint.connectedBody.transform.position;
        Vector2 startPos = transform.position;
        Vector2 direction = (jointPosition - startPos).normalized;

        for (int i = 0; i < numberOfSegments; i++)
        {
            Vector2 targetPos = startPos + direction * (i + 1) * distanceJoint.distance / numberOfSegments;
            float yOffset = Mathf.Sin(Time.time * swingFrequency + i) * swingAmplitude;
            targetPos += Vector2.up * yOffset;
            ropeSegments[i].transform.position = targetPos;
        }
    }
}

