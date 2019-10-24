using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WASD : MonoBehaviour
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
    //private void OnCollisionEnter2D(Collision2D collision)
    //{
    //    Debug.Log("collision!"); 
    
}
