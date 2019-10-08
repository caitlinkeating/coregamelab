﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{

    Rigidbody2D rb;
    public float forceAmount;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) {
            rb.velocity = new Vector2(0f, forceAmount);
            //rb.AddForce(Vector2.up * forceAmount, ForceMode2D.Impulse);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameManager.Larry.score++;
        GameManager.Larry.UpdateScore(); 
        Debug.Log(GameManager.Larry.score); 
    }
}