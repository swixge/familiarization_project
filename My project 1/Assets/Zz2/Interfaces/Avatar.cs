using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IKillable
{
    void Kill();
}

public interface IDamageable<T>
{
    void Damage(T damageTaken);
}

public class Avatar : MonoBehaviour, IKillable, IDamageable<float>
{

   
    public void Kill()
    {
        Debug.Log($"murder was committed pig");
    }

    public void Damage(float damageTaken)
    {
        Debug.Log($"{damageTaken} damage dealt!");
    }
}
