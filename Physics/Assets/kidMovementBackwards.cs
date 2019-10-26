using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kidMovementBackwards : MonoBehaviour
{
    public float speed;
    public float amp;
    public float freq;

    public GameObject pepperkid;


    // Start is called before the first frame update
    void Start()
    {
        speed = 1;
        freq = 1;
        amp = 1;

    }

    // Update is called once per frame
    void Update()
    {


        // transform.Translate(Vector3.forward * Time.deltaTime);



        transform.Translate(new Vector2(-1, 0) * Time.deltaTime);
        //if (transform.position.x >= 9.5)
        //{
        //transform.position = new Vector2(-10, transform.position.y);

        //}
    }
}
