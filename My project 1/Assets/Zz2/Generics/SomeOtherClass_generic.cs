using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SomeClass_generic
{
   
    public T GenericMethod_generic<T>(T param)
    {
        return param;
    }
}

public class SomeOtherClass_generic : MonoBehaviour
{
  
    void Start()
    {
        SomeClass_generic myClass = new SomeClass_generic();
        
        myClass.GenericMethod_generic<int>(5);
    }

}
