using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CameraMovement : MonoBehaviour
{
    public float speed = 2.0f; 

    void Update()
    {
        
        if (Input.GetKey(KeyCode.A))
        {
            
            transform.position += new Vector3(-speed * Time.deltaTime, 0, 0);
        }

     
        if (Input.GetKey(KeyCode.D))
        {
        
            transform.position += new Vector3(speed * Time.deltaTime, 0, 0);
        }
    }
}
   
