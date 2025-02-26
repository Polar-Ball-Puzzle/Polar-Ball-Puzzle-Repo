using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GameManagerScript : MonoBehaviour
{
    public int myScore;
    public Text myScoreGUI;

    public Transform bottomObstacle, topObstacle;
    public float time;
    public float repeatRate;
    public float offset;
    public float ObstacleVelocity;
    public float ObstacleOffset;
  //  private AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        myScore = 0;

        //myScoreGUI = GameObject.Find ("Text").GetComponent<Text>();


        Invoke("ObstacleSpawner",time); // 0.5,1.5
       

      //  audioSource = gameObject.GetComponent<AudioSource>();
    }

    public void GmAddScore()
    {
        myScore++;
        myScoreGUI.text = "Score: "+ myScore.ToString();
       //audioSource.Play();

    }
    void ObstacleSpawner()
    {
        int rand = Random.Range(0, 2);
        

        switch (rand)
        {
            case 0:
                Instantiate(bottomObstacle, new Vector2 (9f,-5.7f), Quaternion.identity);
                bottomObstacle.GetComponent<ObstacleScript>().Velocity = ObstacleVelocity;
                break;
            case 1:
                Instantiate(
                    topObstacle, new Vector2(9f,15f),Quaternion.Euler(0,0,180));
                    topObstacle.GetComponent<ObstacleScript>().Velocity = ObstacleVelocity;
                break;
        }
        repeatRate -= Mathf.Log10(repeatRate) *offset;
        if (ObstacleVelocity <= 35)
        {
            ObstacleVelocity += Mathf.Log10(ObstacleVelocity)*ObstacleOffset;
        }
        
        Invoke("ObstacleSpawner",repeatRate);
    }
    // Update is called once per frame
    void Update()
    {
       
    }
}
