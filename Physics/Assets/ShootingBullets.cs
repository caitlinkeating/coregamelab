using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingBullets : MonoBehaviour
{
    public float bulletVelocity = 8f;

    public GameObject bullet;
    public GameObject bullet1;

    public AudioSource blip; 

    // Start is called before the first frame update
    void Start()
    {
        blip = GetComponent<AudioSource>(); 

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {

            /////////////  /////////////  /////////////  /////////////  /////////////
            Vector3 worldMousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            Vector2 direction = (Vector2)((worldMousePos - transform.position));

            direction.Normalize();

            GameObject bullet = (GameObject)Instantiate(
                bullet1, transform.position + (Vector3)(direction * 0.5f), Quaternion.identity);

            bullet.GetComponent<Rigidbody2D>().velocity = direction * bulletVelocity;
            /////////////  /////////////  /////////////  /////////////  /////////////

            blip.Play(); 
        }



    }
}
