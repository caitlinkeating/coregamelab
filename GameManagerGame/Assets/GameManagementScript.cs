using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManagementScript : MonoBehaviour
{
	public Button PetButton;

	public GameObject cat_prefab;

	int numPets;



	// Start is called before the first frame update
	void Start()
	{
		numPets = 0;
		
	}

	// Update is called once per frame
	void Update()
	{
		
	}


	public void catClicked()
	{
		Instantiate(cat_prefab, transform.position, Quaternion.identity);


	}


}
