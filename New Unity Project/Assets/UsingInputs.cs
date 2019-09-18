using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UsingInputs : MonoBehaviour
{
    float horz;
    float vert;

    Rigidbody2D rb;

    public float forceAmount;

    // Start is called before the first frame update
    void Start()
    {

        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        horz = Input.GetAxis("Horizontal");
        vert = Input.GetAxis("Vertical");

        if (Input.GetKeyDown(KeyCode.P)) ;
        {
            horz = -1f;
        }
        //if (Input.GetKeyDown(KeyCode))

        //Debug.Log(horz + "" + vert);

        //transform.Translate(horz*Time.deltaTime, vert*Time.deltaTime, 0);

        rb.AddForce(new Vector2(horz, vert)*forceAmount);
        //dont forget to change the force amount in unity under the gameobject's script
        //adds momentum
        //when you move in one direction, will be harder to change direction
        //cannot immediately halt motion

        if (Input.GetKey(KeyCode.G)) 
        {
            Debug.Log("hitting g");
            if (Input.GetKey(KeyCode.H))
            {
                Debug.Log("g and h"); 
            }
        }
        else if (Input.GetKey(KeyCode.H))
        {
            Debug.Log("hitting h");
        }

        //else if (Input.GetKey(KeyCode.G) && Input.GetKey(KeyCode.H))
        //{
        //    Debug.Log("g and h"); 
        //}

    }
}
