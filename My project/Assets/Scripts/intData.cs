using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu]
public class intData : ScriptableObject
{
    public int value;

    public void AddToValue(int num)
    {
        value += num;
    }

    public void ResetValue(int num)
    {
        value = num;
    }

}
