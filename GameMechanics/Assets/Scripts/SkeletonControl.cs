using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkeletonControl : MonoBehaviour
{

    Rigidbody2D rb;
    GameObject target;
    public GameObject bullet; 
    

    float moveSpeed;

    Vector3 directiontoTarget; 

    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.Find("flowergirl");
        rb = GetComponent<Rigidbody2D>();
        moveSpeed = Random.Range(1f, 10f); 
    }

    // Update is called once per frame
    void Update()
    {
        MoveMonster();
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        switch (col.gameObject.tag)
        {
            case "Player":
                MSControl.spawnAllowed = false;
                Instantiate(bullet, col.gameObject.transform.position,Quaternion.identity); 
                Destroy(col.gameObject);
                break; 
        }

    }

    void MoveMonster()
    {
        if (target != null)
        {
            directiontoTarget = (target.transform.position - transform.position).normalized;
            rb.velocity = new Vector2(directiontoTarget.x * moveSpeed,
                directiontoTarget.y * moveSpeed); 
        }
        else
        {
            rb.velocity = Vector3.zero; 
        }
    }
   
        
    }

