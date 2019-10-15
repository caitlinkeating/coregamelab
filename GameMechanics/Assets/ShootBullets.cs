using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootBullets : MonoBehaviour
{
    public float bulletVelocity = 5f;

    public GameObject bullet;
    public GameObject bullet1;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Vector3 worldMousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            Vector2 direction = (Vector2)((worldMousePos - transform.position));

            direction.Normalize();

            GameObject bullet = (GameObject)Instantiate(
                bullet1, transform.position + (Vector3)(direction * 0.5f), Quaternion.identity);

            bullet.GetComponent<Rigidbody2D>().velocity = direction * bulletVelocity; 
        }
         
        
    }
}
