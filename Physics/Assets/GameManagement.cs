using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManagement : MonoBehaviour
{
    public static GameManagement manager;

    public Slider healthSlider;

    public float totalHealth;
    public float healthBurn;


    private void Awake()
    {
        {
            if (manager == null)
            {
                manager = this;
                DontDestroyOnLoad(this);
            }
            else if (manager != this)
            {
                Destroy(this.gameObject);
            }
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        healthSlider = GameObject.Find("healthSlider").GetComponent<Slider>();
        healthSlider.minValue = 0f;
        healthSlider.maxValue = totalHealth;

        healthSlider.value = healthSlider.maxValue;

        totalHealth = 5f;

    }

    // Update is called once per frame
    void Update()
    {
        healthSlider.value = totalHealth;

    }

    public void UpdateHealth()
    {
        if (totalHealth > 0)
        {
            totalHealth -= healthBurn;
            healthSlider.value = totalHealth;
        }
        if (totalHealth <= 0)
        {
            //load dead scene 
        }
    }
    public void OnCollisionEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "bird")

        {
            UpdateHealth();
        }
    }
}
