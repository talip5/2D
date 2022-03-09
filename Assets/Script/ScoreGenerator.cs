using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreGenerator : MonoBehaviour
{

    public Text yildiz_Puani;
  // public Text yildiz_Puani10;

    GameObject yildiz5;

    public static int yildiz_puani_int = 0;

    private void Start()
    {
        //yildiz_Puani10 = GameObject.Find("Canvas/Yildiz_Puani(Text)").GetComponent<Text>();
        //yildiz5=GameObject.Find("Karakter");
        //yildiz5.GetComponent<BoxCollider2D>().enabled = false;

    }

    private void Update()
    {
        //yildiz_Puani.text = yildiz_puani_int.ToString();
    }
}
