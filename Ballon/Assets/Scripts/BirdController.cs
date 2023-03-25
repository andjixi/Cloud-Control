using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdController : MonoBehaviour
{
    
    //Vector3 startPos = new Vector3(90f, 20f, 0);
    public float birdSpeed;
    float timer = 0f;

    public bool running = false;

    // Start is called before the first frame update
    void Start()
    { 
        //transform.position = GameObject.FindWithTag("spawn").GetComponent<Spawn>().Spawnpoint.position;
        // 0 0 0
    }

    // Update is called once per frame
    void Update()
    {
        if (running) {
            timer += Time.deltaTime;
            float time = timer % 60;
            Vector3 moveDir = new Vector3(1f, 0f, 0f);
            transform.position -= moveDir * Time.deltaTime * birdSpeed;
            Debug.Log(time);
        }
    }
}