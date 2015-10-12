using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;


public class Unit : MonoBehaviour
{
    public int baseHealth = 100;
    public int damage = 10;
    public Slider healthBar; // Tested healthBars and they do decrement

    void Start()
    {
        baseHealth = health;
    }

    public int health
    {
        get{ return baseHealth; }
        set
        {
            baseHealth = value;
            healthBar.value = baseHealth;

            if (baseHealth <= 0)
            {
                Destroy(gameObject);
            } 
        }
    }

    public void takeDamage(int damage)
    {
        damage = Random.Range(10, 30);
        health -= damage;
    }

    public void attack(GameObject target)
    {
        target.GetComponent<Unit>().takeDamage(damage);
    }
}
