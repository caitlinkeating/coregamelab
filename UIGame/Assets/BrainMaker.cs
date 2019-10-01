using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BrainMaker : MonoBehaviour
{
    public GameObject brain_prefab;
    int brainCount;
    int maxBrains;



    public Slider brainSlider;

    // Start is called before the first frame update
    void Start()
    {
        maxBrains = 12;
    }

    public void CreateBrain()
    {
        Instantiate(brain_prefab, new Vector2(Random.Range(-2f, 2f), 2), Quaternion.identity);
        brainCount++;

        brainSlider.value = brainCount;

        if (brainCount > 50)
        {
            RemoveBrain();
        }

        //Debug.Log(coinCount);
    }
    public void RemoveBrain()
    {
        GameObject[] allBrains;
        allBrains = GameObject.FindGameObjectsWithTag("Brain");

        if (allBrains.Length >= 1)
        {
            int randomBrain = Random.Range(0, allBrains.Length - 1);
            //must do -1 or else the regular length will be 1 more than the last number in our array

            Destroy(allBrains[randomBrain]);
            brainCount--;

            brainSlider.value = brainCount;
        }


    }
    public void SliderUpdate()
    {
        Debug.Log(brainSlider.value);

        if (brainSlider.value > brainCount)
        {
            CreateBrain();
        }
        else if (brainSlider.value < brainCount)
        {
            RemoveBrain();
        }

    }
}