using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefenderMovement : MonoBehaviour
{
    public float speed;
    public Rigidbody2D defenderDi;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        defenderDi.velocity = Vector2.right * speed;
    }
}
