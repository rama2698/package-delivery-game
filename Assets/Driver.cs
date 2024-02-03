using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
    float steerSpeed = 100f;
    float moveSpeed = 3f;

    float boostSpeed = 15f;
    float slowSpeed = 3f;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float steerAmount = Input.GetAxis("Horizontal") * steerSpeed * Time.deltaTime;
        float moveAmount = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
        // function rotate a object
        transform.Rotate(0, 0, -steerAmount);

        // function to move an object
        transform.Translate(0, moveAmount, 0);
    }

    void OnCollisionEnter2D(Collision2D other){
        moveSpeed = slowSpeed;
    }

    void OnTriggerEnter2D(Collider2D other){
        if(other.tag == "Boost"){
            moveSpeed = boostSpeed;
        }

        if(other.tag == "Customer"){
            moveSpeed = slowSpeed;
        }
    }
}
