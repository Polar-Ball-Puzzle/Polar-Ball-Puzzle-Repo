
using UnityEngine;
using UnityEngine.UI;
using System.IO;

public class ShopManager : MonoBehaviour
{
    public ButtonStates buttonStates;
    public Button skin2,skin3,skin4,skin5,skin6;
    public int TotalCoins;
    public Button  buy2, buy3, buy4, buy5, buy6;
  //  public Text coins;
    private string ButtonStatesPath;
    public Text TotalCoinsText;

    // Start is called before the first frame update
    void Start()
    {

        ButtonStatesPath = $"{Application.persistentDataPath}/ButtonStates.json";
        if (File.Exists(ButtonStatesPath))
        {
            string json = File.ReadAllText(ButtonStatesPath);
            buttonStates = JsonUtility.FromJson<ButtonStates>(json);

           // string json = JsonUtility.ToJson(buttonStates);
           // File.WriteAllText(ButtonStatesPath, json);
        }
        TotalCoins = PlayerPrefs.GetInt("Coins");
        RerenderShop();
    }
    // Update is called once per frame
    void Update()
    {
        TotalCoins = PlayerPrefs.GetInt("Coins");
        TotalCoinsText.text = TotalCoins.ToString();
    }
    public void Reset()
    {
        File.Delete(ButtonStatesPath);
    }
    public void CheatCoins()
    {
        PlayerPrefs.SetInt("Coins", 500);
        PlayerPrefs.Save();
    }
    public void BuySkin2( int price)
    {
        if (TotalCoins >= price)
        {
            PlayerPrefs.SetInt("Coins", TotalCoins - price);
            buttonStates.skin2Unlocked = true;
            
            RerenderShop();
            SaveJson();
            
        }
    }
    public void BuySkin3( int price)
    {
        if (TotalCoins >= price)
        {
            PlayerPrefs.SetInt("Coins", TotalCoins - price);
            buttonStates.skin3Unlocked = true;
            RerenderShop();
            SaveJson();
        }
    }
    public void BuySkin4(int price)
    {
        if (TotalCoins >= price)
        {
            PlayerPrefs.SetInt("Coins", TotalCoins - price);
            buttonStates.skin4Unlocked = true;
            RerenderShop();
            SaveJson();
        }
    }
    public void BuySkin5(int price)
    {
        if (TotalCoins >= price)
        {
            PlayerPrefs.SetInt("Coins", TotalCoins - price);
            buttonStates.skin5Unlocked = true;
            RerenderShop();
            SaveJson();
        }
    }
    public void BuySkin6( int price)
    {
        if (TotalCoins >= price)
        {
            PlayerPrefs.SetInt("Coins", TotalCoins - price);
            buttonStates.skin6Unlocked = true;
            RerenderShop();
            SaveJson();
        }
    }
   
   
    public void RerenderShop()
    {
        if (buttonStates.skin2Unlocked)
        {
            skin2.interactable = true;
            buy2.gameObject.SetActive(false);

        }
        if (buttonStates.skin3Unlocked)
        {
            skin3.interactable = true;
            buy3.gameObject.SetActive(false);
        }
        if (buttonStates.skin4Unlocked)
        {
            skin4.interactable = true;
            buy4.gameObject.SetActive(false);
        }
        if (buttonStates.skin5Unlocked)
        {
            skin5.interactable = true;
            buy5.gameObject.SetActive(false);
        }
        if (buttonStates.skin6Unlocked)
        {
            skin6.interactable = true;
            buy6.gameObject.SetActive(false);
        }
       
    }
    private void SaveJson()
    {
        string json = JsonUtility.ToJson(buttonStates);
        File.WriteAllText(ButtonStatesPath, json);
    }

   
}
