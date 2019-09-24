using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shootingskulls : MonoBehaviour   
{
    public GameObject skull;
    public Transform shotlock; 


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.right * Time.deltaTime * 5f);

        //transform.Rotate(new Vector3(0, 0, 1) * Time.deltaTime * 30f);
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(skull, shotlock.position, shotlock.rotation);
        }

    }
}
