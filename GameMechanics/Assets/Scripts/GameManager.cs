using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public float flowers;

	public Text countText; 

	int flowerCount; 


    // Start is called before the first frame update
    void Start()
    {
		flowerCount = 0;

		countText.text = flowerCount.ToString();
	}

    // Update is called once per frame
    void Update()
    {
        
    }

    public void FlowerCollected()
    {
        flowers += 1;
		flowerCount++;

		countText.text = flowerCount.ToString();
	}
}
