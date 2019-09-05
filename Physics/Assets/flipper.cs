using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flipper : MonoBehaviour
{
    Rigidbody2D rb;
    bool isGravityDown;
//using a description for the name is helpful because it will be true/false
   

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        isGravityDown = true;


    }

    // Update is called once per frame
    void Update()
    {
        if (isGravityDown)
        {
            rb.gravityScale = 1;
        }
        else
        {
            rb.gravityScale = -1;
        }
        //if (something is less than something) will be either true or false
        //with boolean, if false it wont do, if true it will do
        //else means what will happen when it is false
        // if (grav) - this is whats going on
        //else - this is whats going on if if (grav) is not going on

        //if (door1 && door2 && door30){
            //something happens
            //example of how to make more complicated boolean 
       
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        isGravityDown = !isGravityDown;
        //! means the opposite
        //so if it is true, it becomes false, etc.
        //doing this bc we want the ball to reverse its gravity when it touches either platform 
    }
}
