using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour {
    
    public Transform Spawnpoint;
    public Transform Spawnpoint2;
    public Transform Spawnpoint3;
    public Transform Spawnpoint4;
    public Transform Spawnpoint5;
    public GameObject Prefab1;
    public GameObject Prefab2;
    public GameObject Prefab3;
    public GameObject Prefab4;
    public GameObject Prefab5;

    void OnTriggerEnter2D(Collider2D other) {

        if(other.gameObject.layer == 3){
        Prefab1.transform.position = Spawnpoint.position;
        Prefab1.GetComponent<BirdController>().running = true;
        Prefab2.transform.position = Spawnpoint2.position;
        Prefab2.GetComponent<BirdController>().running = true;

        Prefab3.transform.position = Spawnpoint3.position;
        Prefab3.GetComponent<BirdController>().running = true;
/*
        Prefab4.transform.position = Spawnpoint4.position;
        Prefab3.GetComponent<BirdController>().running = true;
        Prefab5.transform.position = Spawnpoint5.position;
        Prefab3.GetComponent<BirdController>().running = true;*/
        
        }
    }
    
    void Start()
    {

    }

    void Update()
    {

    }
}
