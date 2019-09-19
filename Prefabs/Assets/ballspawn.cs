using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballspawn : MonoBehaviour
{
    public GameObject Circle; 
    public float threshold;
    float randX;
    Vector2 whereToSpawn;

    float max_x = 10f;
    float max_y = 10f; 

    public float left;
    public float right;
    public float up;
    public float down; 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {



        //if (transform.position.x >= max_x)
        //{
        //    randX = Random.Range(-6.5f, 6.5f);
        //    whereToSpawn = new Vector2(randX, transform.position.y);
        //    Instantiate(Circle, whereToSpawn, Quaternion.identity);
        //}
        //if (transform.position.x < -max_x)
        //{
        //    randX = Random.Range(-6.5f, 6.5f);
        //    whereToSpawn = new Vector2(randX, transform.position.y);
        //    Instantiate(Circle, whereToSpawn, Quaternion.identity);
        //}
        //if (transform.position.y >= max_y)
        //{
        //    randX = Random.Range(-6.5f, 6.5f);
        //    whereToSpawn = new Vector2(randX, transform.position.y);
        //    Instantiate(Circle, whereToSpawn, Quaternion.identity);
        //}
        //if (transform.position.y < -max_y)
        //{
        //    randX = Random.Range(-6.5f, 6.5f);
        //    whereToSpawn = new Vector2(randX, transform.position.y);
        //    Instantiate(Circle, whereToSpawn, Quaternion.identity);
        //}








        //if (transform.position.x > right || transform.position.x < left || transform.position.y > up || transform.position.y < down)
        //{
        //    Instantiate(Circle, whereToSpawn, Quaternion.identity); 
        //}
    }
    //private void FixedUpdate()
    //{
    //    randX = Random.Range(-6.5f, 6.5f);
    //    //whereToSpawn = new Vector2(randX, transform.position.y);
    //    //Instantiate(Circle, whereToSpawn, Quaternion.identity);

    //    if (transform.position.y < threshold)
    //        transform.position = new Vector2(randX,transform.position.y); 
    //}
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "leftwall") 
        {
            Destroy(Circle); 
        }
        if (collision.gameObject.name == "rightwall") 
        {
            Destroy(Circle);
        }
        if (collision.gameObject.name == "topwall") 
        {
            Destroy(Circle);
        }
        if (collision.gameObject.name == "bottomwall") 
        {
            Destroy(Circle);
        }
    }

}

