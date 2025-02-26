using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementScript : MonoBehaviour
{
    public Transform down;
    Transform orig;
    // Start is called before the first frame update
    void Start()
    {
        orig.position = transform.position;
        StartCoroutine(Moving());
    }

    // Update is called once per frame
    void Update()
    {
        StartCoroutine(Moving());
    }
    public void Move()
    {
        transform.position = Vector2.Lerp(transform.position, down.position, 0.5f) * 5;
       // goBack();
    }
    void goBack()
    {
        transform.position = Vector2.Lerp(down.position,orig.position, 0.5f);
        StartCoroutine(Moving());
    }
    IEnumerator Moving()
    {
        Move();
        yield return new WaitForSeconds(5f);
        goBack();

    }
}
