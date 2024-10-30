using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//[CreateAssetMenu(menuName = "Weapon/weapon")]

public abstract class PowerUp : ScriptableObject
{
    public int chance = 1;
    public float cooldown = 1f;
    public float duration = 0f;
    public float power = 1f;

    public abstract void UsePowerUp(Rigidbody rb);
}
