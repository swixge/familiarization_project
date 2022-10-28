using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Player
{
    private int exepirence;

    public int Exepirence
    {
        get
        {
            return exepirence;
        }
        set
        {
            exepirence = value;
        }
    }

    public int Level
    {
        get
        {
            return exepirence / 1000;
        }

        set
        {
            exepirence = value * 1000;
        }
    }

    public int Health { get; set; }

}


public class Game : MonoBehaviour
{

    void Start()
    {

        Player player = new Player();

        player.Exepirence = 5;

        int x = player.Exepirence;

    }

}
