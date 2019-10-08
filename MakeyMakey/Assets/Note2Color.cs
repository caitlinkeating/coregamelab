using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Note2Color : MonoBehaviour
{
    public Sprite Note2A;
    public Sprite Note2B;

    private SpriteRenderer spriteRenderer2; 

    // Start is called before the first frame update
    void Start()
    {
      
        

    }

    // Update is called once per frame
    void Update()
    {
        spriteRenderer2 = GetComponent<SpriteRenderer>();
        if (spriteRenderer2.sprite == null)
            spriteRenderer2.sprite = Note2A;

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            ChangeSprite2(); 
        }
    }
    void ChangeSprite2()
    {
        if (spriteRenderer2.sprite == Note2A)
        {
            spriteRenderer2.sprite = Note2B;
        }
        else
        {
            spriteRenderer2.sprite = Note2A;
        }
    }
}
