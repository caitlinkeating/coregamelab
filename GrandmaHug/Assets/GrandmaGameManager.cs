using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GrandmaGameManager : MonoBehaviour
{
    Rigidbody2D rb; 

    private SpriteRenderer lgsr; 

    public Slider leftgrandmaSlider;

    public Image leftSliderImage;
    public Gradient gradient; 


    public float leftgrandmaTotalHealth;

    public float timer = 0f;
    public float delay2 = 5f; 


    public string leftgrandmaWins;

    public Sprite lgAlive;
    public Sprite lgDead;

    public Vector3 moveDirection; 

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>(); 

        leftgrandmaSlider = GameObject.Find("leftgrandmaSlider").GetComponent<Slider>();
        leftgrandmaTotalHealth = 200;
        leftgrandmaSlider.value = leftgrandmaTotalHealth; 

    }

    // Update is called once per frame
    void Update()
    {
        lgsr = GetComponent<SpriteRenderer>();
        if (lgsr.sprite == null)
            lgsr.sprite = lgAlive; 
        

        if (leftgrandmaSlider.value == 0)
        {
            gameObject.GetComponent<evilgrandma2Controls>().enabled = false;
            Grandma2Death();
            SceneManager.LoadScene("G1Victory");
        }
        
  }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "grandma1")
        {

            leftgrandmaSlider.value -= (Random.Range(0.5f, 8f));

            moveDirection = rb.transform.position - collision.transform.position;
            rb.AddForce(moveDirection.normalized * 40f);

            
        }

    }

    public void UpdateLeftGrandmaHealth()
    {
        leftgrandmaSlider.value -= 5f; 
    }


    public void Grandma2Death()
    {
        if (lgsr.sprite == lgAlive)
        {
            lgsr.sprite = lgDead;
        }
    }
//IEnumerator G1VictoryDelay(float delay2)
//{
//    yield return new WaitForSeconds(delay2);
//    SceneManager.LoadScene("G1Victory");
//}
}
