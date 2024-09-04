using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Car
{
    //Private only this class can access
    //Protected is like private but children can access
    //Public anyclass can access it (It's for the people!)
    protected string colour = "Red";
    protected string owner = "";
    public float speed = 5;

    public Car(string Owner, string Colour, float Speed)
    {
        owner = Owner;
        colour = Colour;
        speed = Mathf.Clamp(Speed, 2f, 100f);
    }

    public void PrintColour()
    {
        Debug.Log(owner + "'s Car is " + colour);
    }

    public string VictorySpeech()
    {
        return Owner() + " proves that the colour " + colour + " is the faster colour.";
    }

    public virtual string Owner()
    {
        return owner;
    }

    public abstract string Honk();
}

public class Tank : Car
{
    public Tank(string Owner, string Colour, float Speed) : base(Owner, Colour, Speed)
    {

    }

    public void Shoot (Car car)
    {
        car.speed = 0f;
        Debug.Log(car.Owner() + "'s car *HONK*");
    }

    public override string Owner()
    {
        return base.Owner() + " IS AN INSANE PERSON!";
    }

    public override string Honk()
    {
        return "BOOM";
    }
}

public class FM1Car : Car
{
    public void EnableHoverMode()
    {
        speed = speed * 2;
    }

    public FM1Car(string Owner, string Colour, float Speed) : base(Owner, Colour, Speed)
    {
        
    }

    public override string Honk()
    {
        return "Vrooomm";
    }
}
