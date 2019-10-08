using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Note4Color : MonoBehaviour
{
    public Sprite Note4A;
    public Sprite Note4B;

    private SpriteRenderer spriteRenderer4;

    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer4 = GetComponent<SpriteRenderer>();
        if (spriteRenderer4.sprite == null)
            spriteRenderer4.sprite = Note4A;
    }

    // Update is called once per frame
    void Update()
    {


        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            ChangeSprite4();
        }
    }
    void ChangeSprite4()
    {
        if (spriteRenderer4.sprite == Note4A)
        {
            spriteRenderer4.sprite = Note4B;
        }
        else
        {
            spriteRenderer4.sprite = Note4A;
        }
    }
}
