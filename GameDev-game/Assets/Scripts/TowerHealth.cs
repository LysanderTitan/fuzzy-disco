using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TowerHealth : MonoBehaviour
{
    public int health;
    public int maxHealth = 50;
    public Slider slider;
    public Sprite[] towerSprites;
    public SpriteRenderer towerSr;
    public GameObject popUpDamagePrefab;
    public TMP_Text popUpText;

    void Start()
    {
        health = maxHealth;
        slider.maxValue = maxHealth;
    }

    public void TakeDamage(int damage)
    {
        health -= damage;
        popUpText.text = damage.ToString();
        Instantiate(popUpDamagePrefab, transform.position, Quaternion.identity);

        slider.value = health;

        if (health <= 0)
        {
            Destroy(slider.gameObject);
            Destroy(gameObject);
        }
        
    }
}
