using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BucketCollision : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //Output screen height and width into console
        Debug.Log("Screen Height: " + Screen.height);
        Debug.Log("Screen Width: " + Screen.width);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(collision.gameObject);
    }
}
