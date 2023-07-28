using UnityEngine;

public class Weapon : MonoBehaviour
{
    //just copying whole code for now ,
    //wont be needing this throwing stuff
    //will delete after its done

    public float throwForce;
    public float throwExtraForce;
    public float rotationForce;

    public int weaponVfxLayer;
    public GameObject weaponGfx;
    public Collider[]  gfxCollider;

    private bool isHeld;
    private Rigidbody _rb;

    private void Start()
    {
        _rb = gameObject.AddComponent<Rigidbody>();
        _rb.mass = 0.1f;

    }

    //pickup drop function

    public void pickup(Transform weaponHolder)
    {
        if (isHeld) return;
        //after pickup object will be destroy
        Destroy(_rb);
        transform.parent = weaponHolder;
        transform.localPosition = Vector3.zero;
        transform.localRotation = Quaternion.identity;
        foreach (var coll in gfxCollider)
        {
            coll.enabled = false;
        }
        isHeld = true;
    }

    public void drop(Transform playerCamera)
    {
        if (!isHeld) return;
        _rb = gameObject.AddComponent<Rigidbody>();
        _rb.mass = 0.3f; 
        var forward = playerCamera.forward;
        _rb.velocity = forward * throwForce;
        _rb.velocity += Vector3.up * throwExtraForce;
        _rb.angularVelocity = Random.onUnitSphere * rotationForce;
        foreach (var coll in gfxCollider)
        {
            coll.enabled = true;
        }
        transform.parent = null;
        isHeld = false;
    }


}
