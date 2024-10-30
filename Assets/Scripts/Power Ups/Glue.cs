using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Power Ups/glue")]

public class Glue : PowerUp
{
    public override void UsePowerUp(Rigidbody rb)
    {
        Rigidbody[] otherRbs = FindObjectsOfType<Rigidbody>();

        HighScoreSystem.instance.StartCoroutine(StickyTime(rb, otherRbs));

        IEnumerator StickyTime(Rigidbody rb, Rigidbody[] otherRbs)
        {
            float startTime = Time.time;

            while (startTime + duration > Time.time)
            {
                for (int i = 0; i < otherRbs.Length; i++)
                {
                    Rigidbody otherRb = otherRbs[i];

                    if (otherRb == rb) continue;

                    if (otherRb.gameObject.layer == LayerMask.NameToLayer("Marble"))
                    {
                        continue;
                    }

                    float reduction = Mathf.Clamp01(Mathf.InverseLerp(100f, 0f, power));
                    otherRb.velocity *= reduction;
                }

                yield return new WaitForFixedUpdate();
            }
        }
    }
}
