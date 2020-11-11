using System;
using UnityEngine;

public class Target : MonoBehaviour
{
    [SerializeField]
    private int currentHealth = 20;

    public void TakeDamage (int amount)
    {
        currentHealth += amount;
        Debug.Log(amount);
    }

    internal void ApplyEffect(Action action)
    {
        action();
    }
}