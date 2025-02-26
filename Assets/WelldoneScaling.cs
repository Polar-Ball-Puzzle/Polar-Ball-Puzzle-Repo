using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WelldoneScaling : MonoBehaviour
{
    Vector2 newScale;
    // Start is called before the first frame update
    void Start()
    {
      newScale = new Vector2(0.47f, 0.47f); 
    }

    // Update is called once per frame
    void Update()
    {
      transform.localScale=  Vector2.Lerp(transform.localScale, newScale,0.3f);
    }
}
