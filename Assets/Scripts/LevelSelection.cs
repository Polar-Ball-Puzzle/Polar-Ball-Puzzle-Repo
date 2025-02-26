using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelSelection : MonoBehaviour
{
    public Button[] levelButtons;

    // Start is called before the first frame update
    void Start()
    {
        int levelat = PlayerPrefs.GetInt("levelat", 2);

        for(int i =0 ; i < levelButtons.Length; i++)
        {
            if(i+2 > levelat)
            {
                levelButtons[i].interactable = false;
            }
        }

        foreach (Button button in levelButtons)
        {
           // make it such that if a goal is collected once it would dissapear,add 3 coins and never appear again
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
