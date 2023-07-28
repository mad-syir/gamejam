using UnityEngine;

public class weaponManager : MonoBehaviour
{
    public float pickupRange;
    public float pickupRadius;

    public int weaponLayer;
    public Transform weaponHolder;
    public Transform playerCamera;

    private bool isWeaponHeld;
    private Weapon heldWeapon;

    private void Update()
    {
       
    }
}
