using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishScript : MonoBehaviour
{
    public GameObject panel;
    public GameObject karakter;

    private void OnCollisionEnter2D(Collision2D temas)
    {
       if(temas.gameObject.tag == "karakter" && ScoreGenerator.yildiz_puani_int == 10)
        {
            panel.SetActive(true);
            karakter.SetActive(false);
        } 
    }
}
