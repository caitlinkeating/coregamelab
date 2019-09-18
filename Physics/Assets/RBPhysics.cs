using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RBPhysics : MonoBehaviour
{
    Rigidbody2D rb;
    public float forceamount;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.AddForce(Vector2.up * forceamount);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
