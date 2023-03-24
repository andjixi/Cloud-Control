using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cloudGenerateScriptLeft : MonoBehaviour
{
    public GameObject cloud;

    public float spawnRate = 5;
    private float timer = 0;

    public float weightOffset = 10;

    // Start is called before the first frame update
    void Start()
    {
        spawnCloud();
    }

    // Update is called once per frame
    void Update()
    {
        if(timer < spawnRate)
            timer += Time.deltaTime;
        else
        {
            spawnCloud();
            timer = 0;
        }
    }

    void spawnCloud()
    {
        float left = transform.position.x - weightOffset;
        float right = transform.position.x + weightOffset;

        Instantiate(cloud, new Vector3(Random.Range(left, right), transform.position.y, 0), transform.rotation);
    }
}