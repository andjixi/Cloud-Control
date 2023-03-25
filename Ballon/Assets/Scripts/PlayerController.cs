using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public float speed = 70f;
    private int deadZone = 19;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 inputVector = new Vector2(0, 0);

        if(Input.GetKey(KeyCode.D)){
            inputVector.x += 1;
        }
        if(Input.GetKey(KeyCode.A)){
            inputVector.x += -1;
        }

        Vector3 moveDir = new Vector3(inputVector.x, 0f, 0f);

        transform.position += moveDir * Time.deltaTime * speed;

       if(transform.position.x < -deadZone) 
            transform.position = new Vector3(-19f, 0f, 0f);

       if(transform.position.x > deadZone) 
            transform.position = new Vector3(19f, 0f, 0f);
    }
}
