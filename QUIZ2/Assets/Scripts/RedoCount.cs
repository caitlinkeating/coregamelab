using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class RedoCount : MonoBehaviour
{

    float timeLeft = 5f;
    public Text countDown;

    bool isHovering; 

    // Start is called before the first frame update
    void Start()
    {
        isHovering = false; 
    }

    // Update is called once per frame
    void Update()
    {
        if (isHovering)
        {
            OnMouseOver();


        }
    }

    public void OnMouseOver()
    {

        Debug.Log("touching");
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("getting close");


    }
}
