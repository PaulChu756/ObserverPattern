using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;


public class Unit : MonoBehaviour
{
    public int baseHealth = 100;
    public int attackDamage = 20;
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
                //gameObject.GetComponent<MeshRenderer>()
            } 
        }
    }

    public void takeDamage()
    {
        attackDamage = Random.Range(5, 50);
        health -= attackDamage;
    }

    public void attack(GameObject target)
    {
        target.GetComponent<Unit>().takeDamage();
    }
}
