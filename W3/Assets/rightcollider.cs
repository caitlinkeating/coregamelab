using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class rightcollider : MonoBehaviour

{
    public float righthand; 
    
    // Start is called before the first frame update


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // void OnTriggerEnter2D(Collider2D other)
    //{
    //    if (other.name == "lefthand")
    //        SceneManager.LoadScene("Scene2");
    //}

    private void OnCollisionExit2D(Collision2D collision)
    {
     if (gameObject.name == "righthand")
        {
            SceneManager.LoadScene("Scene2"); 
        }
    }
}