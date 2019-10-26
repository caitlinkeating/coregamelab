using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dragDrop : MonoBehaviour
{

    private Vector3 offset;

    void OnMouseDown()
    {

        offset = gameObject.transform.position -
            Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, 3.5f));
    }

    void OnMouseDrag()
    {
        Vector3 newPosition = new Vector3(Input.mousePosition.x, 3.5f);
        transform.position = Camera.main.ScreenToWorldPoint(newPosition) + offset;
    }
}

