using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SideScrollScript : MonoBehaviour
{
    Material material;
    Vector2 offset;

 

    public float xVelocity;
    public int yVelocity; 

    private void Awake()
    {
        material = GetComponent<Renderer>().material;
        xVelocity = 0.05f; 
    }

    // Start is called before the first frame update
    void Start()
    {
        offset = new Vector2(xVelocity, yVelocity); 
    }

    // Update is called once per frame
    void Update()
    {
        material.mainTextureOffset += offset * Time.deltaTime; 
    }

   
}
