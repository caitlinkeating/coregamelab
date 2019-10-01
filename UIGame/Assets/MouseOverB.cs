using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class MouseOverB : MonoBehaviour
{
  

    Color m_MouseOverColor = new Color(230,8,255);
    Color m_OriginalColor;
    MeshRenderer m_Renderer;


    // Start is called before the first frame update
    void Start()
    {
        m_Renderer = GetComponent<MeshRenderer>();
        m_OriginalColor = m_Renderer.material.color;
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void OnMouseOver()
    {
        m_Renderer.material.color = m_MouseOverColor; 
    }
    public void OnMouseExit()
    {
        m_Renderer.material.color = m_OriginalColor; 
    }

    public void OnMouseDown()
    {
        SceneManager.LoadScene("BrainOrderScene"); 
    }

}

  
    

