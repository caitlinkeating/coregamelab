using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Note3Color : MonoBehaviour
{
    public Sprite Note3A;
    public Sprite Note3B;

    private SpriteRenderer spriteRenderer3;

    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer3 = GetComponent<SpriteRenderer>();
        if (spriteRenderer3.sprite == null)
            spriteRenderer3.sprite = Note3A;
    }

    // Update is called once per frame
    void Update()
    {
       

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            ChangeSprite3();
        }
    }
    void ChangeSprite3()
    {
        if (spriteRenderer3.sprite == Note3A)
        {
            spriteRenderer3.sprite = Note3B;
        }
        else
        {
            spriteRenderer3.sprite = Note3A;
        }
    }
}
