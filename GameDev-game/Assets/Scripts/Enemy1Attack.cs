using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Enemy1Attack : MonoBehaviour
{
    public int damage = 25;
    public float knockbackForce = 5;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.GetComponent<TowerHealth>())
        {
            collision.gameObject.GetComponent<TowerHealth>().health -= damage;
            Destroy(gameObject);
        }
    
        if(collision.gameObject.GetComponent<DefenderHealth>())
        {
            collision.gameObject.GetComponent<Rigidbody2D>().AddForce(Vector2.left * knockbackForce, ForceMode2D.Impulse);
            collision.gameObject.GetComponent<DefenderHealth>().TakeDamage(damage);
            Destroy(gameObject);
        }
    
        
            
    }
}
