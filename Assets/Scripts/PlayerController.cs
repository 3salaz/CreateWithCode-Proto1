using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // access mofifier like (public) -- private means can only be used within this class  "playerConteroller"
    public float speed = 20.0f;
    public float turnSpeed;
    public float horizontalInput;
    public float forwardInput;

    void Movement()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");
        // moves forward based on vertical input
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput); 
        // rotate based on horizonal input
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput);
    }

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    { 
        Movement();
    }
}
