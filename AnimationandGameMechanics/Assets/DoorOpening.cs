﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpening : MonoBehaviour
{
    Animator anim;


    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>(); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        anim.SetTrigger("OpenDoor"); 
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        anim.SetTrigger("OpenDoor"); 
    }
}
