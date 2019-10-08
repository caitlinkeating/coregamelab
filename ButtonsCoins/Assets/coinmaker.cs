using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class coinmaker : MonoBehaviour
{
    public GameObject coin_prefab;
    int coinCount;
    int maxCoins;

    public InputField inputField; 

    public Slider coinSlider; 

    // Start is called before the first frame update
    void Start()
    {
        maxCoins = 50; 
    }

    public void CreateCoin()
    {
        Instantiate(coin_prefab, new Vector2(Random.Range(-3f, 3f), 5), Quaternion.identity);
        coinCount++;

        coinSlider.value = coinCount; 

        if (coinCount > 50)
        {
            RemoveCoin(); 
        }

        //Debug.Log(coinCount);
    }
    public void RemoveCoin()
    {
        GameObject[] allCoins;
        allCoins = GameObject.FindGameObjectsWithTag("coin");

        if (allCoins.Length >= 1)
        {
            int randomCoin = Random.Range(0, allCoins.Length - 1);
            //must do -1 or else the regular length will be 1 more than the last number in our array

            Destroy(allCoins[randomCoin]);
            coinCount--;

            coinSlider.value = coinCount; 
        }

       
    }
    public void SliderUpdate()
    {
        Debug.Log(coinSlider.value);

        if (coinSlider.value > coinCount)
        {
            CreateCoin(); 
        }
        else if(coinSlider.value < coinCount)
        {
            RemoveCoin(); 
        }        

    }
    //public void TextUpdate()
    //{
    //    Debug.Log(inputField.text);
    //    if (inputField.text == "bonus")
    //    {
    //        maxCoins = 50;
    //        coinSlider.maxValue = 50;
    //        //coinSlider.value = 50;

    //        int difference = maxCoins - coinCount;
    //        for (int i = 0; i <= difference; i++)
    //        {
    //            CreateCoin();
    //        }
    //        inputField.text = "";
    //    }
    //    else if (inputField.text == "blue")
    //    {
    //        coin_prefab.GetComponent<SpriteRenderer>().color = Color.blue;
    //        inputField.text = ""; 
    //    }
    //    else if (inputField.text == "rainbow") {
    //        GameObject[] allCoins;
    //        allCoins = GameObject.FindGameObjectsWithTag("coin");

    //        for (int i = 0; i <= allCoins.Length - 1; i++){
    //            allCoins[i].GetComponent<SpriteRenderer>().color = Random.ColorHSV(0f, 1f, 1f, 1f, 0.5f, 1.5f) ; 
    //        }
    //    }
    }
       
    }

