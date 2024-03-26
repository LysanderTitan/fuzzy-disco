using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pewjectile : MonoBehaviour
{
    public Rigidbody2D pewDefence;
    public float speed = 2.5f;
    public float range = 1;
    private float timer;
    public int damage = 10;
    // Start is called before the first frame update
    void Start()
    {
        timer = range;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        pewDefence.velocity = Vector2.right * speed;

        timer -= Time.deltaTime;
        if(timer <0)
        {
            Destroy(gameObject);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.GetComponent<EnemyHealth>())
        {
            collision.gameObject.GetComponent<EnemyHealth>().health -= damage;
            Destroy(gameObject);
        }
    }
}
