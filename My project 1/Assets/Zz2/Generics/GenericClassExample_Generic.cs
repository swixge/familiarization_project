using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenericClass_Generic<T>
{
    T item;

    public void UpdateItem_Generic(T newItem)
    {
        item = newItem;
    }
}

public class GenericClassExample_Generic : MonoBehaviour
{

    void Start()
    {

        GenericClass_Generic<int> myClass = new GenericClass_Generic<int>();

        myClass.UpdateItem_Generic(5);

    }


}
