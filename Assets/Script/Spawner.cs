using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Spawner : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D temas)
    {
        if(temas.gameObject.tag == "karakter")
        {
            SceneManager.LoadScene(1);
            ScoreGenerator.yildiz_puani_int = 0;
        }
    }
}
