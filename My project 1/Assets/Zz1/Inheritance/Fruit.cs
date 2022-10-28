using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Zz1.Inheritance
{
    public class Fruit1
    {
        public string color;

        public Fruit1()
        {
            color = "orange";
            Debug.Log("1st Fruit Constructor Called");
        }

        public Fruit1(string newColor)
        {
            color = newColor;
            Debug.Log("2nd Fruit Constructor Called");
        }

        public void Chop1()
        {
            Debug.Log("The " + color + " fruit has been chopped.");
        }

        public void SayHello1()
        {
            Debug.Log("Hello, I am a fruit.");
        }
    }


    public class Apple1 : Fruit1
    {
        public Apple1()
        {
            color = "red";
            Debug.Log("1st Apple Constructor Called");
        }

        public Apple1(string newColor) : base(newColor)
        {
            Debug.Log("2nd Apple Constructor Called");
        }
    }


}
