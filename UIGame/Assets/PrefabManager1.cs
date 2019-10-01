using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrefabManager1 : MonoBehaviour
{

    public GameObject brain_prefab;
    public Transform BrainPrefabManager;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(brain_prefab, BrainPrefabManager.position, BrainPrefabManager.rotation);
        }
    }

}
