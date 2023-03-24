using UnityEngine;
using System.Collections;

public class BackAndForth : MonoBehaviour {

    public float delta = 1.5f;  // Amount to move left and right from the start point
    public float speed = 2.0f; 
    private Vector3 startPos;

    void Start () {
        startPos = transform.position;
    }
    
    void Update () {
        Vector3 v = startPos;
        Vector3 a = new Vector3(1f, 0f, 0f);
        v += delta * Mathf.Sin (Time.deltaTime * speed) * a;
        transform.position = v;
    }
}