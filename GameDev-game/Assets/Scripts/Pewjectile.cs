using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pewjectile : MonoBehaviour
{
    public Rigidbody2D pewDefence;
    public float speed = 2.5f;
    public float range = 1;
    private float timer;
    public int damage = 1;
    public float knockbackForce = 5;

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
        if(timer < 0)
        {
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
{
    EnemyHealth enemyHealth = collision.gameObject.GetComponent<EnemyHealth>();
    TowerHealth towerHealth = collision.gameObject.GetComponent<TowerHealth>();
    BaseHealth baseHealth = collision.gameObject.GetComponent<BaseHealth>(); // Assuming you have a BaseHealth script

    if (enemyHealth != null)
    {
        collision.gameObject.GetComponent<Rigidbody2D>().AddForce(Vector2.right * knockbackForce, ForceMode2D.Impulse);
        enemyHealth.TakeDamage(damage);
        Destroy(gameObject);
    }
    else if (towerHealth != null)
    {
        collision.gameObject.GetComponent<Rigidbody2D>().AddForce(Vector2.right * knockbackForce, ForceMode2D.Impulse);
        towerHealth.TakeDamage(damage);
        Destroy(gameObject);
    }
    //else if (towerHealth != null) // Check for base health
    //{
       // collision.gameObject.GetComponent<Rigidbody2D>().AddForce(Vector2.right * knockbackForce, ForceMode2D.Impulse);
      //  towerHealth.TakeDamage(damage); // Apply damage to the base
      //  Destroy(gameObject);
    //}
}

}
