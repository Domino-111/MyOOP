using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndGate : TriggerZone
{
    HighScoreSystem highScore;

    public void Start()
    {
        highScore = FindAnyObjectByType<HighScoreSystem>();
    }

    public override void Activate(Collider collider)
    {
        if (Timer.instance)
        {
            Debug.Log(Timer.instance.CurrentTime());
            highScore.NewScore(Timer.instance.CurrentTime());
        }
    }
}
