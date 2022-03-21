using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]
public static class staticTest
{
    public static int score;


    public static void addScore(int amount)
    {
        score = score + amount;
    }
}
