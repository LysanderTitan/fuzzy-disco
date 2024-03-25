using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public Rigidbody2D enemy1;
    public float speed;

    // Update is called once per frame
    void FixedUpdate()
    {
        enemy1.velocity = Vector2.left * speed;
    }
}
