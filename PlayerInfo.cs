using System;
using UnityEngine;

public class PlayerINFO : MonoBehaviour
{
    public int maxHp;
    public int maxStamina;
    public int Health;
    public int Stamina;

    void Start()
    {
        maxHp = 100;
        maxStamina = 100;
        Health = maxHp;
        Stamina = maxStamina;
    }

    // Method to decrease Player Hp
    public void TakeDamage(int damage)
    {
        Health -= damage;
        if (Health < 0)
        {
            Health = 0;  // To ensure Hp doesn't go below 0
            Debug.Log("Game Over");
        }
    }

    // Method to restore Player Hp
    public void Heal(int amount)
    {
        Health += amount;
        if (Health > maxHp)
        {
            Health = maxHp;
            Debug.Log("Healing");
        }
    }

    // Method to decrease Player Stamina
    public void ReduceStamina(int reduce)
    {
        Stamina -= reduce;
        if (Stamina < 0)
        {
            Stamina = 0;  // To ensure Stamina doesn't go below 0
            Debug.Log("No Stamina");
        }
    }

    // Method to restore Player Stamina
    public void GainStaminas(int amount)
    {
        Stamina += amount;
        if (Stamina > maxStamina)
        {
            Stamina = maxStamina;
            Debug.Log("Gaining ");
        }
    }
}
