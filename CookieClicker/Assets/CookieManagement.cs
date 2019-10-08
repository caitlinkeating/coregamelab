using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CookieManagement : MonoBehaviour
{
    public Text countText;
    int cookieCount;

    public GameObject cookie_prefab;

    public Button bakerButton;
    public Slider bakerSlider;

    float bakingTime;
    float bakingTimer;
    bool canBake;


    // Start is called before the first frame update
    void Start()
    {
        cookieCount = 0;
        bakingTime = 3;
        bakingTimer = 0;

        canBake = true;
        ShowBaker(false);

        countText.text = cookieCount.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        if (cookieCount == 10)
        {
            ShowBaker(true);
        }
        if (!canBake)
        {
            bakingTimer += Time.deltaTime;
            bakerSlider.value = bakingTimer;

            bakerButton.interactable = false;

            if (bakingTimer >= bakingTime)
            {
                cookieCount += 20;
                countText.text = cookieCount.ToString();
                for (int i = 0; i < 20; i++)
                {
                    Instantiate(cookie_prefab, transform.position, Quaternion.identity);
                }
                canBake = true;
                bakingTimer = 0;
                bakerButton.interactable = true;
                bakerSlider.value = bakingTimer;
            }

        }

    }

    void ShowBaker(bool isShowing)
    {
        bakerButton.gameObject.SetActive(isShowing);
        bakerSlider.gameObject.SetActive(isShowing);

        //makes the game object only active under certain conditions 
    }



    public void cookieClicked()
    {
        cookieCount++;
        countText.text = cookieCount.ToString();

        Instantiate(cookie_prefab, transform.position, Quaternion.identity);


        //to instantiate this prefab:
        //make the game object in the scene by dragging it in.
        //drag it back into your assets.
        //delete from scene.
        //use the prefab in assets to attach.


    }

    public void bakerClicked()
    {
        if (cookieCount >= 5)
        {

            canBake = false;
            cookieCount -= 5;
            countText.text = cookieCount.ToString();

        }
    }
}


//to make sure that onclick() works
//make an empty game object that this script is attached to
//then drag the game object itself into the onclick() 
