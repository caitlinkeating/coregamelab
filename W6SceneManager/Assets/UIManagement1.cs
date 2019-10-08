using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManagement1 : MonoBehaviour
{
    public static UIManagement1 Laura;

    public TextAlignment scoreText;

    public int score; 

    private void Awake()
    {
        if (Laura == null)
        {
            Laura = this;
            DontDestroyOnLoad(this);
        }
        else if (Laura != this)
        {
            Destroy(gameObject); 
        }
    }


    public void ShowNewScore(int score)
    {
        scoreText.text = score.ToString(); 
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (score == 3)
        {
            score = 4; 
        }
    }
}
