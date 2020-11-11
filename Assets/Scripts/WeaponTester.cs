using UnityEngine;

public class WeaponTester : MonoBehaviour
{
    [SerializeField]
    private WeaponController currentWeapon;
    [SerializeField]
    private Target target;
    private void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {            
            currentWeapon.Attack(target);
        }
    }    
}
