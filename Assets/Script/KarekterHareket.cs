using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KarekterHareket : MonoBehaviour
{
    private float yatayhareket;
    public int harekethizi;
    public int ziplamahizi;
    public bool karakter_Yerde = true;
    public bool faceright = true;
    public int ZiplamaHakki;

    Rigidbody2D rb;
    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        ZiplamaHakki = 2;
    }

    
    void Update()
    {
        yatayhareket = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(yatayhareket * harekethizi * 100 * Time.deltaTime,rb.velocity.y);

        if (Input.GetKeyDown(KeyCode.Space) && (karakter_Yerde == true || ZiplamaHakki>0))
        {
            rb.velocity = Vector2.up * ziplamahizi * 100 * Time.deltaTime;
            karakter_Yerde = false;
            ZiplamaHakki -= 1;
        }

        if(yatayhareket > 0 && faceright == false)
        {
            turn();
        }


        if (yatayhareket < 0 && faceright == true)
        {
            turn();
        }
    }

    private void OnCollisionEnter2D(Collision2D temas)
    {
        if(temas.gameObject.tag == "zemin")
        {
            karakter_Yerde = true;
            ZiplamaHakki = 2;
        }
    }

    void turn()
    {
        faceright = !faceright;
        Vector2 yeni_Scale = transform.localScale;
        yeni_Scale.x *= -1;
        transform.localScale = yeni_Scale;
    }
}
