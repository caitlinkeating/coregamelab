using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement; 

public class GameManagementQUIZ : MonoBehaviour
{
	public static int coinCount;

	public Slider coinslider;
	public Text coinText;
    
    // Start is called before the first frame update
    void Start()
    {
     
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SliderDragged()
    {
		coinCount++;

		coinText.text = coinslider.value.ToString("0"); 
        
    }

    public void ButtonClicked()
    {
        SceneManager.LoadScene("Scene2"); 
    }
}
