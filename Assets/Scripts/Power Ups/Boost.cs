using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Power Ups/boost")]

public class Boost : PowerUp
{
    public override void UsePowerUp(Rigidbody rb)
    {
        rb.AddForce(rb.velocity.normalized * power, ForceMode.VelocityChange);
    }
}
