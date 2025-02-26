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

    public GameObject uoial;
 // public Button btn1, btn2, btn3, btn4, btn5, btn6, btn7, btn8, btn9, btn10, btn11, btn12, btn13, btn14, btn15, btn16, btn17, btn18, btn19, btn20, btn21, btn22;
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
        // RerenderLevels();
        if (uoial != null)
        {
            if (LevelStates.Level1Completed)
            {
                uoial.SetActive(false);
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
    public void Level13completed()
    {
        if (LevelStates.Level13Completed == false)
        {
            ///   PlayerPrefs.SetInt     award player
            PlayerPrefs.SetInt("Coins", TotalCoins + 3);
            LevelStates.Level3Completed = true;
          //  RerenderLevels();
            SaveJson();
        }


    }
    public void Level14completed()
    {
        if (LevelStates.Level14Completed == false)
        {
            ///   PlayerPrefs.SetInt     award player
            PlayerPrefs.SetInt("Coins", TotalCoins + 3);
            LevelStates.Level14Completed = true;
          //  RerenderLevels();
            SaveJson();
        }


    }
    public void Level15completed()
    {
        if (LevelStates.Level15Completed == false)
        {
            ///   PlayerPrefs.SetInt     award player
            PlayerPrefs.SetInt("Coins", TotalCoins + 3);
            LevelStates.Level15Completed = true;
          //  RerenderLevels();
            SaveJson();
        }


    }
    public void Level16completed()
    {
        if (LevelStates.Level16Completed == false)
        {
            ///   PlayerPrefs.SetInt     award player
            PlayerPrefs.SetInt("Coins", TotalCoins + 3);
            LevelStates.Level16Completed = true;
          //  RerenderLevels();
            SaveJson();
        }
        
    }
    public void Level17completed()
    {
        if (LevelStates.Level17Completed == false)
        {
            ///   PlayerPrefs.SetInt     award player
            PlayerPrefs.SetInt("Coins", TotalCoins + 3);
            LevelStates.Level17Completed = true;
          //  RerenderLevels();
            SaveJson();
        }


    }
    public void Level18completed()
    {
        if (LevelStates.Level18Completed == false)
        {
            ///   PlayerPrefs.SetInt     award player
            PlayerPrefs.SetInt("Coins", TotalCoins + 3);
            LevelStates.Level18Completed = true;
          //  RerenderLevels();
            SaveJson();
        }


    }
    public void Level19completed()
    {
        if (LevelStates.Level19Completed == false)
        {
            ///   PlayerPrefs.SetInt     award player
            PlayerPrefs.SetInt("Coins", TotalCoins + 3);
            LevelStates.Level19Completed = true;
           // RerenderLevels();
            SaveJson();
        }


    }
    public void Level20completed()
    {
        if (LevelStates.Level20Completed == false)
        {
            ///   PlayerPrefs.SetInt     award player
            PlayerPrefs.SetInt("Coins", TotalCoins + 3);
            LevelStates.Level20Completed = true;
          //  RerenderLevels();
            SaveJson();
        }


    }
    public void Level21completed()
    {
        if (LevelStates.Level21Completed == false)
        {
            ///   PlayerPrefs.SetInt     award player
            PlayerPrefs.SetInt("Coins", TotalCoins + 3);
            LevelStates.Level21Completed = true;
          //  RerenderLevels();
            SaveJson();
        }


    }
    public void Level22completed()
    {
        if (LevelStates.Level22Completed == false)
        {
            ///   PlayerPrefs.SetInt     award player
            PlayerPrefs.SetInt("Coins", TotalCoins + 3);
            LevelStates.Level22Completed = true;
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
      /*
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

        if (LevelStates.Level12Completed)
        {
            btn13.interactable = true;

        }

        if (LevelStates.Level13Completed)
        {
            btn14.interactable = true;

        }

        if (LevelStates.Level14Completed)
        {
            btn15.interactable = true;

        }

        if (LevelStates.Level15Completed)
        {
            btn16.interactable = true;

        }

        if (LevelStates.Level16Completed)
        {
            btn17.interactable = true;

        }

        if (LevelStates.Level17Completed)
        {
            btn18.interactable = true;

        }

        if (LevelStates.Level18Completed)
        {
            btn19.interactable = true;

        }

        if (LevelStates.Level19Completed)
        {
            btn20.interactable = true;

        }

        if (LevelStates.Level20Completed)
        {
            btn21.interactable = true;

        }

        if (LevelStates.Level21Completed)
        {
            btn22.interactable = true;

        }

    }*/
    private void SaveJson()
    {
        string json = JsonUtility.ToJson(LevelStates);
        File.WriteAllText(LevelStatesPath, json);
    }


}


