using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    private float playerSpeed = 70f;

    // Start is called before the first frame update
    private void Start()
    {
        
    }

    // Update is called once per frame
    private void Update()
    {
       

        Vector2 inputVector = new Vector2(0, 0);

        if(Input.GetKey(KeyCode.A)){
            inputVector.x -= 1;
        }
        if(Input.GetKey(KeyCode.D)){
            inputVector.x += 1;
        }
        
        transform.position += (Vector3)inputVector * Time.deltaTime * playerSpeed;


    }
}
