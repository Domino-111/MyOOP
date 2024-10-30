using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Power Ups/hammer")]

public class Hammer : PowerUp
{
    public LayerMask mask;
    public float radius = 8f;

    public override void UsePowerUp(Rigidbody rb)
    {
        //int mask = 1 << LayerMask.NameToLayer("Marble");

        Collider[] neighbours = Physics.OverlapSphere(rb.position, 8f, mask);

        foreach (Collider col in neighbours)
        {
            if (col.transform == rb.transform) continue;

            col.attachedRigidbody.AddExplosionForce(power, rb.position, radius);
        }
    }
}
