using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // access mofifier like (public) -- private means can only be used within this class  "playerConteroller"
    public float speed = 20.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MoveForward();
        void MoveForward()
        {
            // 10m / sec speed
            transform.Translate(Vector3.forward * Time.deltaTime * speed); 
        }
        
        // MoveBackwards();
        void MoveBackwards()
        {
            transform.Translate(Vector3.back); 
        }
        
    }
}
