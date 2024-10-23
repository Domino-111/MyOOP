using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Power Ups/boost")]

public class Boost : PowerUp
{
    public override void UsePowerUp(Rigidbody rb)
    {
        rb.AddRelativeForce(Vector3.left * power, ForceMode.VelocityChange);
    }
}
