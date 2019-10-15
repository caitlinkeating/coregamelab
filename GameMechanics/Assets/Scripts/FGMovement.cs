using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FGMovement : MonoBehaviour
{
    public Sprite lookForward;
    public Sprite lookBehind;
    public Sprite lookRight;
    public Sprite lookLeft;

    private SpriteRenderer spriteRenderer;

  

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    


        spriteRenderer = GetComponent<SpriteRenderer>();
        if (spriteRenderer.sprite == null)
        {
            spriteRenderer.sprite = lookForward; 
        }
        if (Input.GetKey(KeyCode.D))
        {
            LookRight();
            
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            LookLeft();
            

        }

        if (Input.GetKeyDown(KeyCode.W))
        {
            LookBehind();
            
        }

        if (Input.GetKeyDown(KeyCode.S)){
            spriteRenderer.sprite = lookForward;
          
        }

    }

    public void LookRight()
    {
        if (spriteRenderer.sprite == lookForward)
        {
            spriteRenderer.sprite = lookRight;
        }
        else
        {
            spriteRenderer.sprite = lookForward;
        }
    }

    public void LookLeft()
    {
        if (spriteRenderer.sprite == lookForward)
        {
            spriteRenderer.sprite = lookLeft; 
        }
        else
        {
            spriteRenderer.sprite = lookForward; 
        }
    }

    public void LookBehind()
    {
        if (spriteRenderer.sprite == lookForward)
        {
            spriteRenderer.sprite = lookBehind;
        }
        else
        {
            spriteRenderer.sprite = lookForward;
        }
    }
}
