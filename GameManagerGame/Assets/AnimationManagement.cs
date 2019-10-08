using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class AnimationManagement : MonoBehaviour
{

    private Animator stickanim;

    float timeToDecrease;
    float amountToDecrease;
    float startTime;

    public float timer;
    public float windUpTime; 


    // Start is called before the first frame update
    void Start()
    {
        stickanim = gameObject.GetComponent<Animator>();
       
    } 

    // Update is called once per frame
    void Update()
    {
   if (Input.GetKey("right"))
        {
            stickanim.speed = 3f; 
        }
        else
        {
            stickanim.speed = 1f; 
        }
if (Input.GetButtonDown("right"))
        {
            timeToDecrease = 1f;
            amountToDecrease = 1f;
            startTime = Time.time; 
        }

if (Input.GetKey("right") && Time.time - timer > windUpTime)
        {
            if(Time.time - startTime > timeToDecrease)
            {
                stickanim.speed += amountToDecrease;
                timeToDecrease -= .2f;
                startTime = Time.time;
            }
        }



    }
}
