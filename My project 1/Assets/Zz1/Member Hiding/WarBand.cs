using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Assets.Zz1.Member_Hiding;

public class WarBand : MonoBehaviour
{
    void Start()
    {
        Humanoid human = new Humanoid();
        Humanoid enemy = new Enemy();
        Humanoid orc = new Orc();

        
        human.Yell();
        enemy.Yell();
        orc.Yell();

    }
}


