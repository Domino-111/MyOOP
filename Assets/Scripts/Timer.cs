using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Singleton
public class Timer : MonoBehaviour
{
    public static Timer instance;

    private float _currentTime = 0f;
    private bool _isTiming = false;

    private void Awake()
    {
        if (instance == null || instance == this)
        {
            instance = this;
        }

        else
        {
            Destroy(this);
        }
    }

    public void StartTime()
    {
        if (!_isTiming)
        {
            _currentTime = 0f;
            _isTiming = true;
        }
    }

    public float CurrentTime()
    {
        return _currentTime;
    }

    public void StopTimer()
    {
        _isTiming = false;
    }

    private void Update()
    {
        if (_isTiming)
        {
            _currentTime += Time.deltaTime;
        }
    }
}
