using System.Diagnostics;
using System.Net;
using Microsoft.VisualBasic;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weather : MonoBehaviour {
    // Start is called before the first frame update
 
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D other)
    { 
        Camera.main.backgroundColor = Color.black;
    }

}