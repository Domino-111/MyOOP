using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarShowroom : MonoBehaviour
{
    void Start()
    {
        //new ClassName() <-- Makes an object out of the class
        FM1Car AnthonyCar = new FM1Car("Anthony", "Red", 69f);
        FM1Car DomCar = new FM1Car("Dom", "Green", 88f);
        Tank AndrewCar = new Tank("Andrew", "Pink", 77f);

        AnthonyCar.PrintColour();
        DomCar.PrintColour();
        AndrewCar.PrintColour();
        DomCar.EnableHoverMode();
        AndrewCar.Shoot(AnthonyCar);

        Race(AnthonyCar, DomCar);
    }

    void Race(Car car1, Car car2)
    {
        if (car1.speed > car2.speed)
        {
            Debug.Log("HERE IS YOUR WINNER: " + car1.VictorySpeech());
        }

        if (car1.speed < car2.speed)
        {
            Debug.Log("HERE IS YOUR WINNER: " + car2.VictorySpeech());
        }
    }
}
