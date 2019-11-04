using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class playerMovement : MonoBehaviour
{
    Rigidbody2D rb;
    float speed;
    int coinCount;
    public Slider coinSlider;

    public GameObject patrol; 

    List<GameObject> coins = new List<GameObject>(); 
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        
        speed = 3f; 
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.up * speed * Time.deltaTime); 
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.down * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * speed * Time.deltaTime);
        }
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "coin")
        {
            Destroy(collision.gameObject);
            coinCount++;
            coinSlider.value = coinCount; 
        }
        if (collision.gameObject.tag == "patrol")
        {
            coinCount--;
            coinSlider.value = coinCount;

            if (coins.Count > 0)
            {
                int randomCoin = Random.Range(0, coins.Count);
                coins[randomCoin].gameObject.SetActive(true);
                coins.Remove(coins[randomCoin]); 
            }
        }
        
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("you're in the box!");
        //patrol.GetComponent<patrolMovement>().isChasing = true;


    }
    public void OnTriggerExit2D(Collider2D collision)
    {
        Debug.Log("you're out of the box!");
        patrolMovement.isChasing = false;
    }
}
