using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SomeOtherClass_LiandDi : MonoBehaviour
{
    void Start()
    {

        Dictionary<string, BadGuyLiandDi> badguys = new Dictionary<string, BadGuyLiandDi>();

        BadGuyLiandDi bg1 = new BadGuyLiandDi("Harvey", 50);
        BadGuyLiandDi bg2 = new BadGuyLiandDi("Magneto", 100);

        badguys.Add("gangster", bg1);
        badguys.Add("mutant", bg2);

        BadGuyLiandDi magneto = badguys["mutant"];

        BadGuyLiandDi temp = null;

        if (badguys.TryGetValue("birds", out temp))
        {
            Debug.Log($"birds here");
        }
        else
        {
            Debug.Log($"there is no bird ");
        }
    }
}
