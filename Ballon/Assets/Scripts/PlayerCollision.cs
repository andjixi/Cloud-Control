using System.Diagnostics;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour {

    public PlayerController mov;
    void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.tag == "cloud") {
            
            mov.enabled = false;
        }
    }
}
