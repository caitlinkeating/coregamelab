﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class evilgrandma1Controls : MonoBehaviour
{
    public float panSpeed = 5f;
    Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = transform.position;

        //if (Input.GetKey("w"))
        //{
        //    pos.y += panSpeed * Time.deltaTime;
        //}
        //if (Input.GetKey("s"))
        //{
        //    pos.y -= panSpeed * Time.deltaTime;
        //}
        //if (Input.GetKey("d"))
        //{
        //    pos.x += panSpeed * Time.deltaTime;
        //}
        if (Input.GetKeyDown("r"))
        {
            pos.x -= panSpeed * Time.deltaTime;
        }


        transform.position = pos;
    }


   
}