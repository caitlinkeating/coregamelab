using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//public class Movement : MonoBehaviour
//{
//    public float speed;
//    public float timer;
//    public GameObject circle;
//    float posx;
//    float posy;
//    public float freq;
//    public float amp;


//    // Start is called before the first frame update
//    void Start()
//    {
//        Debug.Log(transform.position);
//        transform.position = new Vector2(Random.Range(-20, 20), Random.Range(-20, 20));
//        speed = 5;
//        timer = 0;
//        circle.transform.position = new Vector2(0, 0);
//        freq = 1;
//        amp = 1;

//        //transform.Translate(new Vector2(1, 1));
//    }

//    // Update is called once per frame
//    void Update()
//    {
//        if (timer >= 1)
//        {
//            transform.position = new Vector2(Random.Range(-20, 20), Random.Range(-20, 20));
//            timer = 0;
//        }
//        timer += Time.deltaTime;

//        posx = Mathf.Sin(Time.time*freq)*amp;
//        posy = Mathf.Cos(Time.time*freq)*amp;
//        Debug.Log(posx);

//        circle.transform.position = new Vector2(posx + transform.position.x, posy + transform.position.y);
        


//    }


//}
//public class spriteCreate: MonoBehaviour
//{
//    public Texture2D tex;
//    private Sprite mySprite;
//    private SpriteRenderer sr;

//    private void Awake()
//    {
//        sr = gameObject.AddComponent<SpriteRenderer>() as SpriteRenderer;
//        sr.color = new Color(0.9f, 0.9f, 0.9f, 1.0f);

//        transform.position = new Vector3(1.5f, 1.5f, 0.0f);
//    }
//    private void Start()
//    {
//        mySprite = Sprite.Create(tex, new Rect(0.0f, 0.0f, tex.width, tex.height), new Vector2(0.5f, 0.5f), 100.0f);
//    }
//    private void OnGUI()
//    {
//        if (GUI.Button(new Rect(10, 10, 100, 30), "Add sprite"))
//        {  sr.sprite = mySprite;}
    }
}
