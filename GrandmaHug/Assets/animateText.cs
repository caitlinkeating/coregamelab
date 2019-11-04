using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class animateText : MonoBehaviour
{
    public GameObject fighttext;


    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        StartCoroutine(RemoveAfterSeconds(3, fighttext)); 
    }

     IEnumerator RemoveAfterSeconds(int seconds, GameObject txt)
    {
        yield return new WaitForSeconds(2);
        txt.SetActive(false); 
    }
}
