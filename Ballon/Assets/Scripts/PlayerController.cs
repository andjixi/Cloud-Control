using System.Diagnostics;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public float speed = 20f;
    private int deadZone = 19;

    public Rigidbody2D myRigidbody;
    public logicScript logic;
    public GameObject gameOverScreen;

    public bool playerIsAlive = true;

    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("logic").GetComponent<logicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 inputVector = new Vector2(0, 0);

        if(Input.GetKey(KeyCode.D) && playerIsAlive){
            inputVector.x += 1;
        }
        if(Input.GetKey(KeyCode.A) && playerIsAlive){
            inputVector.x += -1;
        }

        Vector3 moveDir = new Vector3(inputVector.x, 0f, 0f).normalized;

        transform.position += moveDir * Time.deltaTime * speed;

        //myRigidbody.velocity = moveDir * Time.deltaTime * speed;

       if(transform.position.x < -deadZone) 
            transform.position = new Vector3(-19f, 0f, 0f);

       if(transform.position.x > deadZone) 
            transform.position = new Vector3(19f, 0f, 0f);
    }

    /*private void OnCollisionEnter2D(Collision2D other)
    {
        logic.gameOver();
    }
    private void OnTriggerEnter2D(Collider2D other){
        if(other.gameObject.tag == "cloud")
            logic.gameOver();
    }*/
    void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.tag == "cloud") {
            gameOverScreen.SetActive(true);
            playerIsAlive = false;
            //logic.score.text = PlayerScore;
        }
    }
}
