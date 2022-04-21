using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{


    public void AddScore(int amount)
    {
        gameData.score += amount;
    }

    public void RemoveLife(int amount)
    {
        gameData.lives -= amount;
    }
}
