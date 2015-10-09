using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class Unit : MonoBehaviour
{
    public int baseHealth;
    public int damage;
    public Slider healthBar;

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
                Destroy(gameObject);
        }
    }

    public void takeDamage(int damage)
    {
        health -= damage;
    }

    public void attack(GameObject target)
    {
        target.GetComponent<Unit>().takeDamage(damage);
    }
}
