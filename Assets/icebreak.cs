using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class icebreak : MonoBehaviour
{

    public GameObject remnantEffect;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Destroy());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator Destroy()
    {
        yield return new WaitForSeconds(2.5f);
        gameObject.SetActive(false);
        Instantiate(remnantEffect, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
}
