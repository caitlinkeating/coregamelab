using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement; 

public class grandma1controls : MonoBehaviour
{
    public float panSpeed = 15f;
    Rigidbody2D rb;

    float delay = 2f;
    public string NextLevel = "FightScene"; 

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = transform.position;

        //if (Input.GetKey("w"))
        //{
        //    pos.y += panSpeed * Time.deltaTime;
        //}
        //if (Input.GetKey("s"))
        //{
        //    pos.y -= panSpeed * Time.deltaTime;
        //}
        //if (Input.GetKey("d"))
        //{
        //    pos.x += panSpeed * Time.deltaTime;
        //}
        if (Input.GetKeyDown("r"))
        {
            pos.x -= panSpeed * Time.deltaTime;
        }
        

        transform.position = pos;
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "grandma2")
        {
            StartCoroutine(LoadLevelAfterDelay(delay));
        }
    }

    IEnumerator LoadLevelAfterDelay(float delay)
    {
        yield return new WaitForSeconds(delay);
        SceneManager.LoadScene("FightScene"); 
        
    }
}

