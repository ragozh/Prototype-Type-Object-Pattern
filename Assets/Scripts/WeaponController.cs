using System;
using UnityEngine;

public class WeaponController : MonoBehaviour
{
    [SerializeField]
    private WeaponData weaponData;
    public void Attack(Target target)
    {
        if (weaponData.Damage > 0)
            target.TakeDamage(-weaponData.Damage);
        if (weaponData.FreezeDuration > 0)
            target.ApplyEffect(Freeze);
        if (weaponData.StunDuration > 0)
            target.ApplyEffect(Stun);

        string message = string.IsNullOrEmpty(weaponData.Message) ? "hit" : weaponData.Message;
        Debug.Log("You " + message + " " + target.name);
    }

    public void Freeze()
    {
        Debug.Log("Freeze for " + weaponData.FreezeDuration);
    }

    public void Stun()
    {
        Debug.Log("Stun for " + weaponData.StunDuration);
    }
}
