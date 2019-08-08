using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IGameControl 
{
    Enemy GetNewEnemy();
    void RewardPlayer(Enemy deadEnemy);
    float GetCurrentGameMultiplier();
}
