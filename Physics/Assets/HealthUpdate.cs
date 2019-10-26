﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class HealthUpdate : MonoBehaviour
{
    public static Slider healthSlider;

    public float totalHealth;
    public float delay = 10;
    public string NextLevel = "DeathScene"; 

    public Image fillSlider;
    public Gradient gradient; 

    void Start()
    {
        healthSlider = GameObject.Find("healthSlider").GetComponent<Slider>();

        totalHealth = 5f;
        healthSlider.value = totalHealth;

        
    }

    void Update()
    {
        if (healthSlider.value <= 4f) //orange
        {
            fillSlider.color = new Color(1f, 0.92f, 0.016f, 1f);
        }
        if (healthSlider.value == 3f) //yellow 
        {
            fillSlider.color = new Color(0.9f, 0.4f, 0, 1f);
        }
        if (healthSlider.value == 2f) // red 
        {
            fillSlider.color = new Color(1f, 0f, 0f, 1f);
        }
        if (healthSlider.value <= 1f) //flash? 
        {
            fillSlider.color = new Color(1f, 0f, 0f, 1f);
            //gameObject.GetComponent<Animator>().Play("HealthFlash");    
            StartCoroutine(LoadLevelAfterDelay(delay));
        }
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log(healthSlider.value);
        if (collision.gameObject.tag == "bird")

        {
            UpdateHealth();
        }
    
    }

    public void UpdateHealth()
    {
        healthSlider.value -= 1f;
    
    }

    IEnumerator LoadLevelAfterDelay(float delay)
    {
        yield return new WaitForSeconds(delay);
        SceneManager.LoadScene("DeathScene");
    }



    
}
