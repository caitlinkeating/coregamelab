﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightControls : MonoBehaviour
{
    public float panSpeed = 10f;

    // Start is called before the first frame update
    void Start()
    {

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
        if (Input.GetKey("l"))
        {
            pos.x -= panSpeed * Time.deltaTime;
        }

        transform.position = pos;
    }
}
