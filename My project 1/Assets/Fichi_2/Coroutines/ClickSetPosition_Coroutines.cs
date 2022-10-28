using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickSetPosition_Coroutines : MonoBehaviour
{

    public PropertiesAndCoroutines_Coroutines coroutineScript;


    void OnMouseDown ()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        Physics.Raycast(ray, out hit);

        if(hit.collider.gameObject == gameObject)
        {
            Vector3 newTarget = hit.point + new Vector3(0, 0.5f, 0);
            coroutineScript.Target = newTarget;
        }
    }
}
