using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class gma1Collision : MonoBehaviour
{
    Rigidbody2D rb;

    private SpriteRenderer rgsr;

    public Slider rightgrandmaSlider;
    public Image rightSliderImage;

    public float rightgrandmaTotalHealth;

    public float timer = 0f;
    private bool startTimer = false;
    public float delay1 = 5f;

    public string rightgrandmaWins;

    public Sprite rgAlive;
    public Sprite rgDead;

    public Vector3 moveDirection;

    public AudioSource smack; 

    Animator anim; 

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rightgrandmaSlider = GameObject.Find("rightgrandmaSlider").GetComponent<Slider>();

        rightgrandmaTotalHealth = 200f;
        rightgrandmaSlider.value = rightgrandmaTotalHealth;

        anim = GetComponent<Animator>();

        smack = GetComponent<AudioSource>(); 
    }

    // Update is called once per frame
    void Update()
    {
        bool isAlive = rgAlive;

        anim.SetBool("isAlive", isAlive);
        if (isAlive)
        {
            anim.Play("evgrandma1"); 
        }

        if (!isAlive)
        {
            anim.Play("ev1dead"); 
        }


        rgsr = GetComponent<SpriteRenderer>();

        if (rgsr.sprite == null)
            rgsr.sprite = rgAlive;

        if (rightgrandmaSlider.value == 0)
        {
            gameObject.GetComponent<evilgrandma1Controls>().enabled = false;
            Grandma1Death();
           
            SceneManager.LoadScene("G2Victory");
        }
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "grandma2")
        {
      
            rightgrandmaSlider.value -= (Random.Range(2f, 6f));
            moveDirection = rb.transform.position - collision.transform.position;
            rb.AddForce(moveDirection.normalized * 40f);

            smack.Play(); 
        }
        
    }

    public void Grandma1Death()
    {
        if (rgsr.sprite == rgAlive)
        {
            rgsr.sprite = rgDead;
        }

       
    }
    //IEnumerator G2VictoryDelay(float delay1)
    //{
    //    yield return new WaitForSeconds(delay1);
    //    SceneManager.LoadScene("G2Victory");
    //}
}
