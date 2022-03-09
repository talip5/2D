using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class karakter1 : MonoBehaviour
{

    private float yatayhareket;
    public int harekethizi;
    public int ziplamahizi;

    Rigidbody2D rb;

    private void Start()
    {
        //Debug.Log("karakter1");
        rb = GetComponent<Rigidbody2D>();
        Debug.Log(rb.name);
    }

    private void Update()
    {
        yatayhareket = Input.GetAxis("Horizontal");
        //Debug.Log(yatayhareket);
        rb.velocity = new Vector2(yatayhareket * harekethizi * 100 * Time.deltaTime,rb.velocity.y);
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.velocity = Vector2.up * ziplamahizi * 100 * Time.deltaTime;
        }
    }

}
