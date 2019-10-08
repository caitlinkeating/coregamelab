﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravFlip1 : MonoBehaviour
{
    Rigidbody2D rb;

   

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>(); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "gravityflip")
        {
            rb.gravityScale *= -1;
            transform.Rotate(180,0,0); 
            
        }
    }
}
