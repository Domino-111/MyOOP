using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using TMPro;
using System.Linq;

public class HighScoreSystem : MonoBehaviour
{
    private List<string> names = new List<string>();
    private List<float> scores = new List<float>();

    public int maxScores = 10;

    public Transform panel;
    public TMP_Text textPrefab;
    
    public static HighScoreSystem instance;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }

        else
        {
            Destroy(gameObject);
        }
    }

    private void Start()
    {
        HighScoreData data = JsonSaveLoad.LoadHighScore();

        if (data != null)
        {
            this.names = data.names.ToList();
            this.scores = data.scores.ToList();
        }
        RefreshScoreDsiplay();
    }

    private void OnDestroy()
    {
        HighScoreData data = new HighScoreData(scores.ToArray(), names.ToArray());

        JsonSaveLoad.SaveHighScore(data);
    }

    private void RefreshScoreDsiplay()
    {
        for (int i = panel.transform.childCount - 1; i >= 0; i--)
        {
            Destroy(panel.GetChild(i).gameObject);
        }

        for (int i = 0; i < scores.Count; i++)
        {
            TMP_Text text = Instantiate(textPrefab, panel);
            text.text = names[i];

            text = Instantiate(textPrefab, panel);
            text.text = scores[i].ToString();
        }
    }

    string[] possibleNames = {"Odin", "Freyja", "Balder", "Thor", "Narvi", "Magni"};
    public void NewScore(float score)
    {
        NewScore(possibleNames[Random.Range(0, possibleNames.Length)], score);
    }

    public void NewScore(string name, float score)
    {
        for (int index = 0; index < scores.Count; index++)
        {
            if (score < scores[index])
            {
                scores.Insert(index, score);
                names.Insert(index, name);
                RefreshScoreDsiplay();

                if (scores.Count > maxScores)
                {
                    scores.RemoveAt(scores.Count - 1);
                    names.RemoveAt(names.Count - 1);
                }

                return;
            }
        }

        if (scores.Count < maxScores)
        {
            scores.Add(score);
            names.Add(name);
            RefreshScoreDsiplay();
        }
    }
}
