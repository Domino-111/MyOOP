using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]

public class HighScoreData
{
    public float[] scores;
    public string[] names;

    //Constructor
    public HighScoreData()
    {
        scores = new[] {99f, 10f, 1f};
        names = new[] {"Andrew", "Alex", "Steve"};
    }

    public HighScoreData(float[] scores, string[] names)
    {
        this.scores = scores;
        this.names = names;
    }
}