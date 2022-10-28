using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fruit
{
    public Fruit()
    {
        Debug.Log("1st Fruit Constructor Called");
    }

    public void Chop()
    {
        Debug.Log("The fruit has been chopped.");
    }

    public void SayHello()
    {
        Debug.Log("Hello, I am a fruit.");
    }
}

public class Apple : Fruit
{
    public Apple()
    {
        Debug.Log("1st Apple Constructor Called");
    }
    public new void Chop()
    {
        Debug.Log("The apple has been chopped.");
    }

    public new void SayHello()
    {
        Debug.Log("Hello, I am an apple.");
    }
}


public class FruitSalad : MonoBehaviour
{
    void Start()
    {
        
        Fruit myFruit = new Apple();

        myFruit.SayHello();
        myFruit.Chop();

        
        Apple myApple = (Apple)myFruit;

        myApple.SayHello();
        myApple.Chop();
    }


}
