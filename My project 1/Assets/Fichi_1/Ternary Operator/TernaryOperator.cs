using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TernaryOperator : MonoBehaviour
{
    void Start()
    {
        int health = 20;
        string message;


        message = health > 0 ? "Player is Alive" : "Player is Dead";
    }
}
