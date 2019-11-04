using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class HealthUpdate : MonoBehaviour
{
    public Sprite alive;
    public Sprite dead;

    private SpriteRenderer sr;

    public static Slider healthSlider;

    public float totalHealth;
    public float timer = 0f;
    //public const float timeleft = 5f; 

    private bool starttimer = false;

    public float delay = 2f;
    public string NextLevel = "DeathScene";

    public Image fillSlider;
    public Gradient gradient;

    Rigidbody2D rb; 

    void Start()
    {
        healthSlider = GameObject.Find("healthSlider").GetComponent<Slider>();

        totalHealth = 5f;
        healthSlider.value = totalHealth;

        rb = GetComponent<Rigidbody2D>(); 

    }

    void Update()
    {
        sr = GetComponent<SpriteRenderer>();
        if (sr.sprite == null)
            sr.sprite = alive;
        

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
        if (healthSlider.value == 1f) //flash? 
        {
            fillSlider.color = new Color(1f, 0f, 0f, 1f);
           
        }
        if (healthSlider.value == 0f)
        {
            fillSlider.color = new Color(1f, 0f, 0f, 1f);
            gameObject.GetComponent<WASD>().enabled = false;
            ChangeSprite(); 

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

    public void ChangeSprite()
    {
        if (sr.sprite == alive)
        {
            sr.sprite = dead;
        }
       
    }




}
