using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BackgroundAnimation : MonoBehaviour
{
    public GameObject MinusIndicator, PlusIndicator, HitWorldEffect;
    /* public Image[] positions;
      public float factor;

      // Start is called before the first frame update
      void Start()
      {
          StartCoroutine(Move());
      }

      // Update is called once per frame
      void Update()
      {

      }

      IEnumerator Move()
      {

          this.GetComponent<RectTransform>().localPosition = Vector2.Lerp(GetComponent<RectTransform>().localPosition, positions[0].rectTransform.localPosition, factor);

          yield return new WaitForSeconds(5f);
          this.GetComponent<RectTransform>().localPosition = Vector2.Lerp(GetComponent<RectTransform>().localPosition, positions[2].rectTransform.localPosition, factor);

          yield return new WaitForSeconds(5f);
          this.GetComponent<RectTransform>().localPosition = Vector2.Lerp(GetComponent<RectTransform>().localPosition, positions[1].rectTransform.localPosition, factor);
          yield return new WaitForSeconds(5f);
          this.GetComponent<RectTransform>().localPosition = Vector2.Lerp(GetComponent<RectTransform>().localPosition, positions[3].rectTransform.localPosition, factor);
          yield return new WaitForSeconds(5f);
          this.GetComponent<RectTransform>().localPosition = Vector2.Lerp(GetComponent<RectTransform>().localPosition, positions[4].rectTransform.localPosition, factor);

          Continue();
      }
      void Continue()
      {
          StartCoroutine(Move());
      }
     */
    public Color plus, minus, neutral;

    private void Awake()
    {
        StartCoroutine(loopPolarity());
    }

    IEnumerator loopPolarity()
    {
        // gameObject.GetComponent<SpriteRenderer>().color = plus; will abandon for now
        PlusIndicator.SetActive(true);
        MinusIndicator.SetActive(false);
        gameObject.layer = 8;
        yield return new WaitForSeconds(4f);
        //   gameObject.GetComponent<SpriteRenderer>().color = minus; same for this
        MinusIndicator.SetActive(true);
        PlusIndicator.SetActive(false);
        gameObject.layer = 9;
        yield return new WaitForSeconds(4f);
        StartCoroutine(loopPolarity());

    }



}
