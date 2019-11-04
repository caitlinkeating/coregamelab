﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class patrolMovement : MonoBehaviour
{
    public GameObject[] patrolPoints;
    public GameObject player; 
    int whichPoint;
    public static bool isChasing;

    float dist;


    // Start is called before the first frame update
    void Start()
    {
        int whichPoint = 0;
        isChasing = false;
        
    }

    // Update is called once per frame
    public void Update()
    {
        if (isChasing)
        {
            transform.position = Vector2.MoveTowards(transform.position, player.transform.position, Time.deltaTime * 3);

        }
        else
        {
            transform.position = Vector2.MoveTowards(transform.position, patrolPoints[whichPoint].transform.position, Time.deltaTime*3);

            dist = Vector2.Distance(transform.position, patrolPoints[whichPoint].transform.position);
            if (dist <= 0.01)
            {
                whichPoint++; 
            }
        }
    }
}
