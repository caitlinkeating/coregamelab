using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EyeMaker : MonoBehaviour
{
    public GameObject eye_prefab;
    int eyeCount;
    int maxEyes;



    public Slider eyeSlider;

    // Start is called before the first frame update
    void Start()
    {
        maxEyes = 12;
    }

    public void CreateEyes()
    {
        Instantiate(eye_prefab, new Vector2(Random.Range(-6f, 6f), 5), Quaternion.identity);
        eyeCount++;

        eyeSlider.value = eyeCount;

        if (eyeCount > 50)
        {
            RemoveEyes();
        }

        //Debug.Log(coinCount);
    }
    public void RemoveEyes()
    {
        GameObject[] allEyes;
        allEyes = GameObject.FindGameObjectsWithTag("Eyes");

        if (allEyes.Length >= 1)
        {
            int randomEye = Random.Range(0, allEyes.Length - 1);
            //must do -1 or else the regular length will be 1 more than the last number in our array

            Destroy(allEyes[randomEye]);
            eyeCount--;

            eyeSlider.value = eyeCount;
        }


    }
    public void SliderUpdate()
    {
        Debug.Log(eyeSlider.value);

        if (eyeSlider.value > eyeCount)
        {
            CreateEyes();
        }
        else if (eyeSlider.value < eyeCount)
        {
            RemoveEyes();
        }

    }

}
