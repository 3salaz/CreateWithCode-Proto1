using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
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
            transform.Translate(Vector3.forward * Time.deltaTime * 10); 
        }
        
        // MoveBackwards();
        void MoveBackwards()
        {
            transform.Translate(Vector3.back); 
        }
        
    }
}
