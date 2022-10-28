using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MulticastScript_Delegates : MonoBehaviour
{
    delegate void MultiDelegate();
    MultiDelegate myMultiDelegate;


    void Start () 
    {
        myMultiDelegate += PowerUp;
        myMultiDelegate += TurnRed;

        if(myMultiDelegate != null)
        {
            myMultiDelegate();
        }
    }

    void PowerUp()
    {
        print ("Orb is powering up!");
    }

    void TurnRed()
    {
        GetComponent<Renderer>().material.color = Color.red;
    }
}
