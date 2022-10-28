using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System; 

public class BadGuyLiandDi : IComparable<BadGuyLiandDi>
{
    public string name;
    public int power;

    public BadGuyLiandDi(string newName, int newPower)
    {
        name = newName;
        power = newPower;
    }

 
    public int CompareTo(BadGuyLiandDi other)
    {
        if (other == null)
        {
            return 1;
        }

        return power - other.power;
    }
}




public class SomeClass_LiandDi : MonoBehaviour
{

    private void Start()
    {

        List<BadGuyLiandDi> badguys = new List<BadGuyLiandDi>();

        badguys.Add(new BadGuyLiandDi("Harvey", 50));
        badguys.Add(new BadGuyLiandDi("Magneto", 100));
        badguys.Add(new BadGuyLiandDi("Pip", 5));

        badguys.Sort();

        foreach (BadGuyLiandDi guy in badguys)
        {
            print(guy.name + " " + guy.power);
        }

        badguys.Clear();
    }
    
}
