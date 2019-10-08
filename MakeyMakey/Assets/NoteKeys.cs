using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NoteKeys : MonoBehaviour
{
    public AudioSource someSound;
    public AudioSource anotherSound;
    public AudioSource athirdSound;
    public AudioSource lastSound;

    public Sprite Note1A;
    public Sprite Note1B;

   

    private SpriteRenderer spriteRenderer;

    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        if (spriteRenderer.sprite == null)
            spriteRenderer.sprite = Note1A;
    
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            someSound.Play();
            ChangeSprite1(); 
            //GetComponent<SpriteRenderer>().sprite = Note1A; 
        }
        //if (Input.GetKeyUp(KeyCode.UpArrow)){
        //    GetComponent<SpriteRenderer>().sprite = Note1B; 
        //}

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            anotherSound.Play();
            
            //GetComponent<SpriteRenderer>().sprite = Note2A;
        }
        //if (Input.GetKeyUp(KeyCode.RightArrow)){
        //    GetComponent<SpriteRenderer>().sprite = Note2B;
        //}
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            athirdSound.Play();
            //GetComponent<SpriteRenderer>().sprite = Note3A;
        }
        //if (Input.GetKeyUp(KeyCode.LeftArrow)){
        //    //GetComponent<SpriteRenderer>().sprite = Note3B;
        //}
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            lastSound.Play();
            //GetComponent<SpriteRenderer>().sprite = Note4A;
        }
        //if (Input.GetKeyUp(KeyCode.DownArrow)){
        //    //GetComponent<SpriteRenderer>().sprite = Note4B;
        //}
       
    }

    void ChangeSprite1()
    {
        if (spriteRenderer.sprite == Note1A)
        {
            spriteRenderer.sprite = Note1B;
        }
        else
        {
            spriteRenderer.sprite = Note1A; 
        }
     

    }
}
