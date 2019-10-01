using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TeethMaker : MonoBehaviour
{
    public GameObject teeth_prefab;
    int teethCount;
    int maxTeeth;



    public Slider teethSlider;

    // Start is called before the first frame update
    void Start()
    {
        maxTeeth = 12;
    }

    public void CreateTeeth()
    {
        Instantiate(teeth_prefab, new Vector2(Random.Range(-6f, 6f), 5), Quaternion.identity);
        teethCount++;

        teethSlider.value = teethCount;

        if (teethCount > 50)
        {
            RemoveTeeth();
        }

        //Debug.Log(coinCount);
    }
    public void RemoveTeeth()
    {
        GameObject[] allTeeth;
        allTeeth = GameObject.FindGameObjectsWithTag("Teeth");

        if (allTeeth.Length >= 1)
        {
            int randomTeeth = Random.Range(0, allTeeth.Length - 1);
            //must do -1 or else the regular length will be 1 more than the last number in our array

            Destroy(allTeeth[randomTeeth]);
            teethCount--;

            teethSlider.value = teethCount;
        }


    }
    public void SliderUpdate()
    {
        Debug.Log(teethSlider.value);

        if (teethSlider.value > teethCount)
        {
            CreateTeeth();
        }
        else if (teethSlider.value < teethCount)
        {
            RemoveTeeth();
        }

    }

    }
