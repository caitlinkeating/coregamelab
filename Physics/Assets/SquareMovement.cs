﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SquareMovement : MonoBehaviour
{
    Vector2 direction;
    float spinForce;
    Rigidbody2D rb;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
      
        direction = new Vector2(Random.Range(-1.0f, 1.0f), Random.Range(-1.0f, -1.0f));
        spinForce = Random.Range(1.0f, 5.0f);

        rb = GetComponent<Rigidbody2D>();
        rb.AddForce(direction, ForceMode2D.Impulse);
        rb.AddTorque(spinForce);

    }

    // Update is called once per frame
    void Update()
    {
        speed = 5;
    }
}