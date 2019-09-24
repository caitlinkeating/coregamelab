using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletmove : MonoBehaviour
{
    float timer;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.right * Time.deltaTime * 5f);

        timer += Time.deltaTime;
        if (timer > 0.5f)
        {
            Destroy(this.gameObject); 
        }
        //destroys gameobject on a timer
    }


}
