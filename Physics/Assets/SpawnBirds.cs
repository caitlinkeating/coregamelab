using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBirds : MonoBehaviour
{
    public GameObject bird;

    float randX;
    float randY;
    public float spawnRate = 3f;
    public float nextSpawn = 4f;

    Vector2 whereToSpawn;


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
            Instantiate(bird, whereToSpawn, Quaternion.identity);
        }
    }
}
