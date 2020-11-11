using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Freeze : AttackEffect
{
    [SerializeField]
    private float speedValueSlowed;
    public override void SlowForDuration(float amount, float duration)
    {
        Debug.Log("Slow to " + speedValueSlowed * (1 - amount) + " for " + duration);
    }
}
