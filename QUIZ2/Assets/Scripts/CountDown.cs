using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Threading; 

public class CountDown : MonoBehaviour
{
    public int timeLeft = 5;
    public Text countDown;

    //IEnumerator coroutine; 


    // Start is called before the first frame update
    void Start()
    {
        //print("Starting" + Time.time); 
        //coroutine = WaitandPrint(5.0f);
        //StartCoroutine(coroutine);
        //print("before waitandprint finishes" + Time.time); 

        StartCoroutine("LoseTime");
        Time.timeScale = 1;

    }

    // Update is called once per frame
    void Update()
    {
        countDown.text = ("" + timeLeft);
    }

    IEnumerator LoseTime()
    {
        while (true)
        {
            yield return new WaitForSeconds(1);
            timeLeft--;
        }
    }

    private void OnMouseEnter()
    {
       
      
       

    }



}
