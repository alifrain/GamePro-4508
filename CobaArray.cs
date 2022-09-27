using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CobaArray : MonoBehaviour
{
    // Start is called before the first frame update
    public string[] items;

    void Start()
    {
        for (int i = 0; i < items.Length; i++)
            Debug.Log (items[i]);    
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
