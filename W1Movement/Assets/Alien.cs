using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Alien : MonoBehaviour

{
    public float speed;
    public float freq;
    public float amp;
    public GameObject Alien1;

    // Start is called before the first frame update
    void Start()
    {
        speed = 7;
        freq = 5;
        amp = 5;
    }

    // Update is called once per frame
    void Update()
    {
        transform.localScale = new Vector2(Mathf.Sin(Time.time), 1);

        transform.Translate(new Vector2(10, 0) * Time.deltaTime);
        if (transform.position.x >= 29)
        {
            transform.position = new Vector2(-29, transform.position.y);

        }
    }
}
