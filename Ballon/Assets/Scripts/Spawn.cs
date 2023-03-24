using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour {
    
    public Transform Spawnpoint;
    public Transform Spawnpoint2;
    public Transform Spawnpoint3;
    public GameObject Prefab1;
    public GameObject Prefab2;
    public GameObject Prefab3;

    void OnTriggerEnter2D() {
        Instantiate (Prefab1, Spawnpoint.position, Spawnpoint.rotation);
        Instantiate (Prefab2, Spawnpoint2.position, Spawnpoint2.rotation);
        Instantiate (Prefab3, Spawnpoint3.position, Spawnpoint3.rotation);
    }
    
    void Start()
    {

    }

    void Update()
    {

    }
}
