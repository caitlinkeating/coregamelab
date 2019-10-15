using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManagementScript : MonoBehaviour
{
    public Text countPets; 

    public Button PetButton;
    public Slider catSlider;

    public GameObject cat_prefab;

	int numPets;

    float petTime;
    float petTimer;

    bool isAsleep; 

	// Start is called before the first frame update
	void Start()
	{
		numPets = 0;
        petTime = 5;
        petTimer = 0;

        isAsleep = true;
        

        countPets.text = numPets.ToString(); 
		
	}

	// Update is called once per frame
	void Update()
	{
		if (numPets == 10)
        {

        }
        if (!isAsleep)
        {
            //change sprite to other cat 
        }
	}


	public void catClicked()
	{
		Instantiate(cat_prefab, transform.position, Quaternion.identity);


	}

    public void catChange()
    {
    }




}
