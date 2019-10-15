﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterSpawning : MonoBehaviour
{
    public GameObject monster;
    float randX;

    Vector2 whereToSpawn;

    public float spawnRate = 5f;
    float nextSpawn = 4f; 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > nextSpawn)
        {
            nextSpawn = Time.time + spawnRate;
            randX = Random.Range(-6.5f, 6.5f);
            whereToSpawn = new Vector2(randX, transform.position.y);

            Instantiate(monster, whereToSpawn, Quaternion.identity);
        }
    }
}
