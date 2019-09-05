using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//apply force to a circle using addForce and RigidBody2D
//add a public float for forceamount to 

public class TriggerZone : MonoBehaviour
{
    Rigidbody2D rb;
    public float forceamount;  
    //make a game object for the planet as well as its position 
    public GameObject[] planets = new GameObject[4];
    //this makes an array which is a list of variables, now that we have more than 1 planet 
    Vector3 planet_pos;
    Vector3 direction;
    //adding a distance vector to see which planet is closest 
    float distance;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        //planet_pos = planet.transform.position;

        //give the circle an inital push since it is without gravity
        //will help move towards the desired object
        //we put this in void start because it occurs once on start

        rb.AddForce(Vector2.left * 10, ForceMode2D.Impulse);

        //can change the number 10 in order to make the circular motion bigger, etc.

        distance = Vector3.Distance(planets[0].transform.position, transform.position);
        //this is our distance check
        planet_pos = planets[0].transform.position;
    }

    // Update is called once per frame
    private void Update()
    {
        direction = planet_pos - transform.position;
        //make sure there is a Vector for the direction stated under class
        rb.AddForce(direction * forceamount);

        //foreach command
        //foreach (array which is game objects + p for planet in planets)

        foreach (GameObject planet in planets)
        {

            float distcheck = Vector3.Distance(planet.transform.position, transform.position);
            if (distcheck < distance)
                planet_pos = planet.transform.position;
            distance = distcheck;
            //distcheck is a temporarily created variable
            //the function under Update is what brings it closer to the planets 
            {

            }
                //(planet's position BETWEEN our position) is what parenthesis mean
                //this checks the distance between each planet 
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        Debug.Log("triggered!");
        //we put (0,1) because X coordinate = 0 and Y coordinate = 1.
        //can also just put "up"
        //now, as long as we are in the trigger zone, it will add a steady upward force to our circle
        // make sure this part is within the ontrigger so it will work 
        rb.AddForce(Vector2.up * forceamount);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        
    }
}
