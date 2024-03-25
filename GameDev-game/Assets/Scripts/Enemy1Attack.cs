using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Enemy1Attack : MonoBehaviour
{
    public int damage = 25;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.GetComponent<BaseHealth>())
        {
            collision.gameObject.GetComponent<BaseHealth>().health -= damage;
            Destroy(gameObject);
        }
    }
}
