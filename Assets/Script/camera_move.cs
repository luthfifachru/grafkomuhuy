﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera_move : MonoBehaviour
{
  
    void Start()
    {
    	GetComponent<Rigidbody>().velocity = new Vector3(0, 0, -3);    
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
