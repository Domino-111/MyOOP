using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    List<Marble> marbles = new List<Marble>();

    Vector3 Offset = new Vector3(5f, 10f, 5f);

    private void Start()
    {
        marbles = FindObjectsOfType<Marble>().ToList();
        marbles = marbles.OrderBy(n => n.transform.position.y).ToList();
    }

    private void Update()
    {
        Vector3 avPosition;

        if (Vector3.Distance(marbles[0].transform.position, marbles[1].transform.position) < 5f)
        {
            avPosition = (marbles[0].transform.position + marbles[1].transform.position + marbles[2].transform.position) / 3;
        }

        else
        {
            avPosition = marbles[0].transform.position;
        }

        transform.position = avPosition + Offset;

        transform.LookAt(avPosition);
    }

    private void FixedUpdate()
    {
        marbles = marbles.OrderBy(n => n.transform.position.y).ToList(); //Orders the list by y position in scene
    }
}
