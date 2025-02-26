using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Events;
public class KeyCollectionScript : MonoBehaviour
{
    public int nextSceneLoad;
   // public int currentLevel;
    public GameObject welldoneText;

     LevelManagerr managerr;
    [SerializeField] private UnityEvent levelCleared;
    [SerializeField] GameObject goalEffect;
    private void Start()
    {
      //  nextSceneLoad = SceneManager.GetActiveScene().buildIndex + 1;
      managerr = FindObjectOfType<LevelManagerr>();
    }

    public IEnumerator ChangeScene()
    {
        welldoneText.SetActive(true);
        yield return new WaitForSeconds(6f);
        PlayerPrefs.SetInt("Attempts", 1);
        SceneManager.LoadScene(nextSceneLoad);

        //  loadingPanel.SetActive(false);  // will look into 

    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            if (SceneManager.GetActiveScene().buildIndex == 23)
            {
                // return attempts number to zero
                Instantiate(goalEffect, transform.position, Quaternion.identity);
                StartCoroutine(ChangeScene());
                levelCleared.Invoke();
                SceneManager.LoadScene(0);
               // PlayerPrefs.DeleteAll(); // will remove all progress
            }
            else
            {

                if (nextSceneLoad > PlayerPrefs.GetInt("levelat"))
                {
                    PlayerPrefs.SetInt("levelat", nextSceneLoad);
                }
                Instantiate(goalEffect, transform.position, Quaternion.identity);
                StartCoroutine(ChangeScene());
                levelCleared.Invoke();
               

            }

        }
       
    }


}
