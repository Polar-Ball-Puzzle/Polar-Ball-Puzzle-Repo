using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    public Color plus, minus,neutral;
    public GameObject[] minusObjects;
    public GameObject[] plusObjects;
    public float ForceMagnitude;
    public GameObject WelldoneObject;
    public GameObject MinusIndicator, PlusIndicator;
    public GameObject[] avatars;
    public int selectedAvatar;
    public GameObject Blackholeobjs;
   
    public Text attemptsText;
    public float intensity;
    public float time;
    // Start is called before the first frame update
    void Start()
    {
        plusObjects = GameObject.FindGameObjectsWithTag("Plus");
        minusObjects = GameObject.FindGameObjectsWithTag("Minus");
        selectedAvatar = PlayerPrefs.GetInt("selectedOption");
        avatars[selectedAvatar].SetActive(true);
        
        if(selectedAvatar == null)
        {
            avatars[0].SetActive(true);
        }
        if (selectedAvatar ==5)
        {
          //  Blackholeobjs.SetActive(true);
        }
      //  attempts= PlayerPrefs.GetInt("Attempts");
    }

    // Update is called once per frame
    void Update()
    {
        if(attemptsText!= null)
        {
            attemptsText.text = "ATTEMPT:" + PlayerPrefs.GetInt("Attempts").ToString();
        }
       
    }
    public void ChangeColorPlus()
    {
      //  gameObject.GetComponent<SpriteRenderer>().color = plus;
        gameObject.layer = 8;
        PlusIndicator.SetActive(true);
        MinusIndicator.SetActive(false);
        foreach( GameObject plus in plusObjects)
        {
            plus.GetComponent<PointEffector2D>().forceMagnitude = ForceMagnitude;// -plus.GetComponent<PointEffector2D>().forceMagnitude;
         
        }
        foreach (GameObject minus in minusObjects)
        {
            minus.GetComponent<PointEffector2D>().forceMagnitude = -ForceMagnitude;// -plus.GetComponent<PointEffector2D>().forceMagnitude;

        }
    }

    public void ChangeColorMinus()
    {
      //  gameObject.GetComponent<SpriteRenderer>().color = minus;
        gameObject.layer =9;
        MinusIndicator.SetActive(true);
        PlusIndicator.SetActive(false);
        foreach (GameObject plus in plusObjects)
        {
            plus.GetComponent<PointEffector2D>().forceMagnitude = -ForceMagnitude;// -plus.GetComponent<PointEffector2D>().forceMagnitude;

        }
        foreach (GameObject minus in minusObjects)
        {
            minus.GetComponent<PointEffector2D>().forceMagnitude = ForceMagnitude;// -plus.GetComponent<PointEffector2D>().forceMagnitude;

        }
    }
    public void ChangeToNeutral()
    {
        gameObject.GetComponent<SpriteRenderer>().color = neutral;
        gameObject.layer = 0;
        MinusIndicator.SetActive(false);
        PlusIndicator.SetActive(false);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
       /* if(collision.gameObject.tag == "Goal")
        {
            WelldoneObject.SetActive(true);
            Destroy(collision.gameObject);
            StartCoroutine(countDown());
            this.gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);
        }*/
    }
    IEnumerator countDown()
    {
        yield return new WaitForSeconds(5);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (this.gameObject)
        {
            if (collision.gameObject.tag == "Death")
            {
              //  ScreenShake.instance.shakeCamera(intensity, time);
                int prevattempts = PlayerPrefs.GetInt("Attempts") + 1;
                PlayerPrefs.SetInt("Attempts", prevattempts);
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

               
            }
        }
        
        if(collision.gameObject.name== "Spring Joint")
        {
            gameObject.GetComponent<SpringSwitch>().ActivateDoor();
        }
        if (collision.gameObject != false)
        {
           // Instantiate(HitWorldEffect, transform.position, Quaternion.identity);
        }

        if (collision.gameObject.CompareTag("Minus") || collision.gameObject.CompareTag("Plus"))
        {
            Debug.Log("Shake");
            ScreenShake.instance.shakeCamera(intensity, time);
        }
    }
}
