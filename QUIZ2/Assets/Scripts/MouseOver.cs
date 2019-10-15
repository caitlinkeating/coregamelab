using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MouseOver : MonoBehaviour
{
    private Vector3 mousePosition;
    private Rigidbody2D rb;
    private Vector2 direction;
    private float moveSpeed;
    public float delay = 10; 

    private static int count;

    bool isHovering; 

    float timeLeft = 10f;
    public Text countDown;

    // Start is called before the first frame update
    void Start()
    {
        isHovering = true; 
        rb = GetComponent<Rigidbody2D>();

        StartCoroutine(LoadLevelAfterDelay(delay)); 
        
    }

    IEnumerator LoadLevelAfterDelay(float delay){
        yield return new WaitForSeconds(delay);
        SceneManager.LoadScene("GameOver"); 
    }

    // Update is called once per frame
    void Update()
    {
        moveSpeed = GameManagementQUIZ.coinCount; 

        mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        direction = (mousePosition - transform.position).normalized;
        rb.velocity = new Vector2(direction.x * moveSpeed, direction.y * moveSpeed);

        if (isHovering)
        {
            timeLeft -= Time.deltaTime;
            countDown.text = "Time Left:" + Mathf.Round(timeLeft);
            if (timeLeft <= 0)
            {
                SceneManager.LoadScene("GameOver");
            }
            Debug.Log("collision detected"); 
        }


    }
  

 
  
    
       

    }



