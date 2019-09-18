using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bigbullets : MonoBehaviour
{
    public GameObject bullet_p;
    public Transform shotLoc; 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(0, 0, 1) * Time.deltaTime * 30f);
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(bullet_p, shotLoc.position, shotLoc.rotation); 
        }
        //shoots bullets
        //make sure to make the bullet a prefab because it will get destroyed.
        //the prefab gets placed under bullet in script inspector 
    }
}
