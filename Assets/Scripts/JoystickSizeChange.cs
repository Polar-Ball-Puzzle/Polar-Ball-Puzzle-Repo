using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JoystickSizeChange : MonoBehaviour
{
    public float currentValue;
    RectTransform rTransform;
  //  public string prefSaveX,prefSaveY;
    // Start is called before the first frame update
    void Start()
    {
        currentValue = PlayerPrefs.GetFloat("SliderValue");
        rTransform = GetComponent<RectTransform>();
        rTransform.localScale = new Vector3(currentValue, currentValue, currentValue);

        
        if (currentValue == 0 || currentValue <=0.22)
        {
            rTransform.localScale = new Vector3(0.4660365f, 0.4660365f, 0.4660365f);
        }

        LoadPosition();
    }
    // Update is called once per frame
    void Update()
    {
        rTransform.localScale = new Vector3(currentValue, currentValue, currentValue);
        if (currentValue == 0 || currentValue <= 0.22)
        {
            rTransform.localScale = new Vector3(0.4660365f, 0.4660365f, 0.4660365f);
        }
    }
    private void LoadPosition()
    {
       

        if(this.gameObject.name=="Plus Button")
        {
            if (PlayerPrefs.HasKey("UIPositionXP") && PlayerPrefs.HasKey("UIPositionYP"))
            {
                float posX = PlayerPrefs.GetFloat("UIPositionXP");
                float posY = PlayerPrefs.GetFloat("UIPositionYP");
                rTransform.anchoredPosition = new Vector2(posX, posY);
            }
          
        } else if( this.gameObject.name == "Minus Button")
        {
            if (PlayerPrefs.HasKey("UIPositionXM") && PlayerPrefs.HasKey("UIPositionYM"))
            {
                float posX = PlayerPrefs.GetFloat("UIPositionXM");
                float posY = PlayerPrefs.GetFloat("UIPositionYM");
                rTransform.anchoredPosition = new Vector2(posX, posY);
            }
          
        } else if(this.gameObject.name == "Neutral Button")
        {
            if (PlayerPrefs.HasKey("UIPositionXN") && PlayerPrefs.HasKey("UIPositionYN"))
            {
                float posX = PlayerPrefs.GetFloat("UIPositionXN");
                float posY = PlayerPrefs.GetFloat("UIPositionYN");
                rTransform.anchoredPosition = new Vector2(posX, posY);
            }
           
        }
    }
}
