using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class DefenderHealth : MonoBehaviour
{
    public int health;
    public int maxHealth = 10;
    public float delayTime = .15f;
    public Movement movement;
    public GameObject popUpDamage;
    public TMP_Text popUpText;
    // Start is called before the first frame update
    void Start()
    {
        health = maxHealth;
    }

    public void TakeDamage(int damage)
    {
        health -= damage;
        popUpText.text = damage.ToString();
        Instantiate(popUpDamage, transform.position, Quaternion.identity);
        StartCoroutine(knockbackDelay());
    }



    IEnumerator knockbackDelay()
    {
        movement.enabled = false;
        yield return new WaitForSeconds(delayTime);
        
        if(health <= 0)
        {
            Destroy(gameObject);
        }
        else
        {
            movement.enabled = true;
        }
    }
}


