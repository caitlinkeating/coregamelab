using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FaceWASD : MonoBehaviour
{
    public float panSpeed = 10f;

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

        if (Input.GetKey("up"))
        {
            pos.y += panSpeed * Time.deltaTime;
        }
        if (Input.GetKey("down"))
        {
            pos.y -= panSpeed * Time.deltaTime;
        }
        if (Input.GetKey("right"))
        {
            pos.x += panSpeed * Time.deltaTime;
        }
        if (Input.GetKey("left"))
        {
            pos.x -= panSpeed * Time.deltaTime;
           
        }

        transform.position = pos;
    }

}
