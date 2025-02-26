using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationScript : MonoBehaviour
{
  public  Vector3 rotationVector;
   public int zdirection;
    
    private void Start()
    {
        rotationVector.z = zdirection;
    }



    private void Update()
    {
        transform.Rotate(rotationVector * Time.deltaTime);
      
    }
}
