﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeypadPiedras : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnMouseDown(){
        Debug.Log("Hice click en : "+ gameObject.name);
        LogicaGemas.agregarGemas(gameObject.name);

    }
}
