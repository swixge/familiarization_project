﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Zz2.Method_Overloading
{
    public class SomeClass_Method_Overloading
    {


        public int Add(int num1, int num2)
        {
            return num1 + num2;
        }


        public string Add(string str1, string str2)
        {
            return str1 + str2;
        }

    }
}
