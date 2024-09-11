using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndGate : TriggerZone
{
    public override void Activate(Collider collider)
    {
        if (Timer.instance)
        {
            Debug.Log(Timer.instance.CurrentTime());
        }
    }
}
