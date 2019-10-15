using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tileManager : MonoBehaviour
{
    public Color darkpink;
    public Color lightgreen;

    public GameObject sprite; 
    public Sprite Xsprite;
    public Sprite Osprite;

    public bool isX; 


    // Start is called before the first frame update
    public void SetTile(bool _XorO)
    {
        isX = _XorO; 

        if (_XorO)
        {
            GetComponent<SpriteRenderer>().color = darkpink;
            sprite.GetComponent<SpriteRenderer>().sprite = Xsprite;
        }
        else
        {
            GetComponent<SpriteRenderer>().color = lightgreen;
            sprite.GetComponent<SpriteRenderer>().sprite = Osprite;
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
