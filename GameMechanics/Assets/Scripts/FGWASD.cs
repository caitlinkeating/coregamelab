using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FGWASD : MonoBehaviour
{
    public float panSpeed = 10f;

    GameManager gm; 

    // Start is called before the first frame update
    void Start()
    {
        gm = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = transform.position;

        if (Input.GetKey("w"))
        {
            pos.y += panSpeed * Time.deltaTime;
        }
        if (Input.GetKey("s"))
        {
            pos.y -= panSpeed * Time.deltaTime;
        }
        if (Input.GetKey("a"))
        {
            pos.x -= panSpeed * Time.deltaTime;
        }
        if (Input.GetKey("d"))
        {
            pos.x += panSpeed * Time.deltaTime;
        }

        transform.position = pos;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "flower")
        {
            gm.FlowerCollected();
            Destroy(other.gameObject); 
        }

        if(other.tag == "nextscene1")
        {
            SceneManager.LoadScene("Scene2"); 
        }
    }
}
