using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public static class ExtensionMethods_Extension
{

    public static void ResetTransformation_Extension(this Transform trans)
    {
        trans.position = Vector3.zero;
        trans.localRotation = Quaternion.identity;
        trans.localScale = new Vector3(1, 1, 1);
    }
}


public class SomeClass_Extension : MonoBehaviour
{

    void Start()
    {

        transform.ResetTransformation_Extension();

    }

}
