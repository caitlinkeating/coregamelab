using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collisionspawn : MonoBehaviour
  
{
    public GameObject PrefabH; 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.name == "grandma2")
        {

            //Instantiate(PrefabH, new Vector2(transform.position.x, transform.position.y + 7f), transform.rotation);
            //return;
            Instantiate(PrefabH, new Vector2(gameObject.transform.position.x, gameObject.transform.position.y), Quaternion.identity);
        }
    }
}
