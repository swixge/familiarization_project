using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Assets.Zz2.Method_Overloading;

public class SomeOtherClass_Method_Overloading : MonoBehaviour
{

    void Start()
    {
        SomeClass_Method_Overloading myClass = new SomeClass_Method_Overloading();


        myClass.Add(1, 2);
        myClass.Add("Hello ", "World");
    }

}
