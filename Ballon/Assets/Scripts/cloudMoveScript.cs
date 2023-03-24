using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cloudMoveScript : MonoBehaviour
{
    public float moveSpeed = 8f;
    public float deadZone = -15;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 moveDir = new Vector3(0f, 1f, 0f);
        transform.position -= moveDir * moveSpeed * Time.deltaTime;

        if(transform.position.y < deadZone)
            Destroy(gameObject);
    }
}
