﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CAr : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        Collider[] hitcollider = Physics.OverlapSphere(transform.position , 5f); // attached to the car so I can know when the car passes the final checkpoint 
        
    }
}
