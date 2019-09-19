using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class platformmove : MonoBehaviour
{
    //public float speed;
    //public float moveSpeed = 6;

    Rigidbody rb;
    Camera viewCamera;
    Vector3 velocity;

    public float speed = 5f;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        viewCamera = Camera.main;


        //GetComponent<SpriteRenderer>().color = Random.ColorHSV(0f, 1f, 1f, 1f, 0.5f, 1f);

        //if (Input.GetKeyDown(KeyCode.Space))
        //    {
        //        GetComponent<SpriteRenderer>().color = Random.ColorHSV(0f, 1f, 1f, 1f, 0.5f, 1f);
    }
    //change color to make the sprites appear as random colors 


    // Update is called once per frame
    void Update()
    {



        if (Input.GetKeyDown(KeyCode.Space))
        {
            GetComponent<SpriteRenderer>().color = Random.ColorHSV(0f, 1f, 1f, 1f, 0.5f, 1f);
        }

        //Vector3 mousePos = viewCamera.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, viewCamera.transform.position.y));

        Vector2 direction = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        float angle = Mathf.Atan2(direction.x, direction.y) * Mathf.Rad2Deg;
        Quaternion rotation = Quaternion.AngleAxis(angle, Vector3.forward);

        //transform.LookAt(mousePos + Vector3.down * transform.position.y);

        transform.rotation = Quaternion.Slerp(transform.rotation, rotation, speed * Time.deltaTime);


        //make the platforms rotate towards mouse position
        //Vector3 mousePos = viewCamera.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, viewCamera.transform.position.y));
        //transform.LookAt(mousePos + Vector3.up * transform.position.y);
        //velocity = new Vector3(Input.GetAxisRaw("Vertical"), 0, Input.GetAxisRaw("Horizontal")).normalized * moveSpeed;

        //void FixedUpdate()
        //{
        //    rb.MovePosition(rb.position + velocity * Time.fixedDeltaTime); 
        //}
    }
}




  

   //transform.Translate(Vector2.down * speed * Time.deltaTime);

    //if (transform.position.y <= -15)
    //{
    //    Destroy(this.gameObject);
    //}

  

