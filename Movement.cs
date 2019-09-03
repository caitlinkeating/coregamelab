using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(transform.position);
        transform.position = new Vector2(Random.Range(-20, 20), Random.Range(-20, 20));
        speed = 5;
        //transform.Translate(new Vector2(1, 1));
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector2(1, 0)*Time.deltaTime*speed);
        //Time.deltaTime
    }
}
