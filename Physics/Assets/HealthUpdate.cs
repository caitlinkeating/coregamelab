using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthUpdate : MonoBehaviour
{
    public Slider healthSlider;

    public float totalHealth;


    //public Color maxHealthColor = Color.green;
    //public Color minHealthColor = Color.red;

    public Image fillSlider;

    public Gradient gradient;

    public float t; 

    // Start is called before the first frame update
    void Start()
    {
        healthSlider = GameObject.Find("healthSlider").GetComponent<Slider>();
        //healthSlider.minValue = 0;
        //healthSlider.maxValue = totalHealth;

        totalHealth = 5f;
        healthSlider.value = totalHealth; 

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

        if (healthSlider.value >= 4f) //orange
        {
            fillSlider.color = new Color(1f, 0.92f, 0.016f, 1f);
        }
        if (healthSlider.value == 3f) //yellow 
        {
            fillSlider.color = new Color(0.9f, 0.4f, 0, 1f);
        }
        if(healthSlider.value == 2f) // red 
        {
            fillSlider.color = new Color(1f, 0f, 0f, 1f); 
        }
       if(healthSlider.value <= 1f) //flash? 
        {
            gameObject.GetComponent<Animator>().Play("HealthFlash");

        }
    
    }

    
}
