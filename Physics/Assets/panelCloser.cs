using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class panelCloser : MonoBehaviour
{
    public GameObject panel;

    public void ClosePanel()
    {
      
            panel.SetActive(false);
        
    }
}
