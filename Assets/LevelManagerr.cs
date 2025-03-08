using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;



public class LevelManagerr : MonoBehaviour
{
    public LevelStates LevelStates;
   
    public int TotalCoins;
  
    //  public Text coins;
    private string LevelStatesPath;

    public GameObject Tutorial;
    public Button btn1, btn2, btn3, btn4, btn5, btn6, btn7, btn8, btn9, btn10, btn11, btn12;
    // Start is called before the first frame update
    void Start()
    {

        LevelStatesPath = $"{Application.persistentDataPath}/LevelStates.json";
        if (File.Exists(LevelStatesPath))
        {
            string json = File.ReadAllText(LevelStatesPath);
            LevelStates = JsonUtility.FromJson<LevelStates>(json);

            // string json = JsonUtility.ToJson(buttonStates);
            // File.WriteAllText(ButtonStatesPath, json);
        }
        TotalCoins = PlayerPrefs.GetInt("Coins");
         RerenderLevels();
        if (Tutorial != null)
        {
            if (LevelStates.Level1Completed)
            {
                Tutorial.SetActive(false);
            }
        }
        
    }
    // Update is called once per frame
    void Update()
    {
        TotalCoins = PlayerPrefs.GetInt("Coins");
       
    }
    public void Reset()
    {
        File.Delete(LevelStatesPath);
    }

   
    public void Level1completed()
    {
        if(LevelStates.Level1Completed== false)
        {
            ///   PlayerPrefs.SetInt     award player
            PlayerPrefs.SetInt("Coins", TotalCoins +3);
            LevelStates.Level1Completed = true;
          //  RerenderLevels();
            SaveJson();
        }
      
        
    }
    public void Level2completed()
    {
        if (LevelStates.Level2Completed == false)
        {
            ///   PlayerPrefs.SetInt     award player
            PlayerPrefs.SetInt("Coins", TotalCoins + 3);
            LevelStates.Level2Completed = true;
          //  RerenderLevels();
            SaveJson();
        }


    }
    public void Level3completed()
    {
        if (LevelStates.Level3Completed == false)
        {
            ///   PlayerPrefs.SetInt     award player
            PlayerPrefs.SetInt("Coins", TotalCoins + 3);
            LevelStates.Level3Completed = true;
          //  RerenderLevels();
            SaveJson();
        }


    }
    public void Level4completed()
    {
        if (LevelStates.Level4Completed == false)
        {
            ///   PlayerPrefs.SetInt     award player
            PlayerPrefs.SetInt("Coins", TotalCoins + 3);
            LevelStates.Level4Completed = true;
          //  RerenderLevels();
            SaveJson();
        }


    }
    public void Level5completed()
    {
        if (LevelStates.Level5Completed == false)
        {
            ///   PlayerPrefs.SetInt     award player
            PlayerPrefs.SetInt("Coins", TotalCoins + 3);
            LevelStates.Level5Completed = true;
          //  RerenderLevels();
            SaveJson();
        }


    }
    public void Level6completed()
    {
        if (LevelStates.Level6Completed == false)
        {
            ///   PlayerPrefs.SetInt     award player
            PlayerPrefs.SetInt("Coins", TotalCoins + 3);
            LevelStates.Level6Completed = true;
           // RerenderLevels();
            SaveJson();
        }


    }
    public void Level7completed()
    {
        if (LevelStates.Level7Completed == false)
        {
            ///   PlayerPrefs.SetInt     award player
            PlayerPrefs.SetInt("Coins", TotalCoins + 3);
            LevelStates.Level7Completed = true;
          //  RerenderLevels();
            SaveJson();
        }


    }
    public void Level8completed()
    {
        if (LevelStates.Level8Completed == false)
        {
            ///   PlayerPrefs.SetInt     award player
            PlayerPrefs.SetInt("Coins", TotalCoins + 3);
            LevelStates.Level8Completed = true;
          //  RerenderLevels();
            SaveJson();
        }


    }
    public void Level9completed()
    {
        if (LevelStates.Level9Completed == false)
        {
            ///   PlayerPrefs.SetInt     award player
            PlayerPrefs.SetInt("Coins", TotalCoins + 3);
            LevelStates.Level9Completed = true;
          //  RerenderLevels();
            SaveJson();
        }


    }
    public void Level10completed()
    {
        if (LevelStates.Level10Completed == false)
        {
            ///   PlayerPrefs.SetInt     award player
            PlayerPrefs.SetInt("Coins", TotalCoins + 3);
            LevelStates.Level10Completed = true;
          //  RerenderLevels();
            SaveJson();
        }
        
    }
    public void Level11completed()
    {
        if (LevelStates.Level11Completed == false)
        {
            ///   PlayerPrefs.SetInt     award player
            PlayerPrefs.SetInt("Coins", TotalCoins + 3);
            LevelStates.Level11Completed = true;
          //  RerenderLevels();
            SaveJson();
        }


    }
    public void Level12completed()
    {
        if (LevelStates.Level12Completed == false)
        {
            ///   PlayerPrefs.SetInt     award player
            PlayerPrefs.SetInt("Coins", TotalCoins + 3);
            LevelStates.Level12Completed = true;
          //  RerenderLevels();
            SaveJson();
        }
        
    }


    /*  public void BuySkin2(int price)
      {
          if (TotalCoins >= price)
          {
              PlayerPrefs.SetInt("Coins", TotalCoins - price);
              buttonStates.skin2Unlocked = true;

              RerenderShop();
              SaveJson();

          }
      }*/
    
   public void RerenderLevels()
   {
       if (LevelStates.Level1Completed)
       {
           btn2.interactable = true;

       }

      if (LevelStates.Level2Completed)
      {
          btn3.interactable = true;

      }

      if (LevelStates.Level3Completed)
      {
          btn4.interactable = true;

      }

      if (LevelStates.Level4Completed)
      {
          btn5.interactable = true;

      }

      if (LevelStates.Level5Completed)
      {
          btn6.interactable = true;

      }

      if (LevelStates.Level6Completed)
      {
          btn7.interactable = true;

      }

      if (LevelStates.Level7Completed)
      {
          btn8.interactable = true;

      }

      if (LevelStates.Level8Completed)
      {
          btn9.interactable = true;

      }

      if (LevelStates.Level9Completed)
      {
          btn10.interactable = true;

      }

      if (LevelStates.Level10Completed)
      {
          btn11.interactable = true;

      }

      if (LevelStates.Level11Completed)
      {
          btn12.interactable = true;

      }

      //if (LevelStates.Level12Completed)
      //{
      //    btn13.interactable = true;

      //}

      


   }
    private void SaveJson()
    {
        string json = JsonUtility.ToJson(LevelStates);
        File.WriteAllText(LevelStatesPath, json);
    }


}


