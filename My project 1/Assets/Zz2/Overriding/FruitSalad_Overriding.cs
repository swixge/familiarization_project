using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Assets.Zz2.Overriding;

public class FruitSalad_Overriding : MonoBehaviour
{
    void Start()
    {
        Apple_Overriding myApple = new Apple_Overriding();


        myApple.SayHello_Overriding();
        myApple.Chop_Overriding();


        Fruit_Overriding myFruit = new Apple_Overriding();
        myFruit.SayHello_Overriding();
        myFruit.Chop_Overriding();
    }

}
