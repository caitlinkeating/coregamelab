using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour

{
public static GameManager Larry;

	private void Awake()
	{
		if (Larry == null)
		{
			Larry = this;
			DontDestroyOnLoad(this);
		}
		else if (Larry != this)
		{
			Destroy(gameObject);
		}
	}


		public int score;

    public void UpdateScore()
	{
		UIManagement.Laura.ShowNewScore(score); 
	}


		// Start is called before the first frame update
		void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    
	}

	


}
