using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Assets.Zz1.Inheritance;

public class FruitSalad1 : MonoBehaviour
{

    void Start()
    {

        Debug.Log("Creating the fruit");
        Fruit1 myFruit = new Fruit1();
        Debug.Log("Creating the apple");
        Apple1 myApple = new Apple1();


        myFruit.SayHello1();
        myFruit.Chop1();


        myApple.SayHello1();
        myApple.Chop1();


        Debug.Log("Creating the fruit");
        myFruit = new Fruit1("yellow");
        Debug.Log("Creating the apple");
        myApple = new Apple1("green");

        myFruit.SayHello1();
        myFruit.Chop1();

        myApple.SayHello1();
        myApple.Chop1();

    }

}
