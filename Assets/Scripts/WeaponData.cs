using UnityEngine;

[CreateAssetMenu(menuName = "Weapon Data")]
public class WeaponData : ScriptableObject
{
    public int Damage;
    public string Message;
    public int FreezeDuration;
    public int StunDuration;
}
