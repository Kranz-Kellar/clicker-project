using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IUIControl
{
    void UpdateUICurrentEnemyHealth(float maxHealth, float currentHealth);
    void UpdateUICurrentEnemySprite(Sprite newEnemySprite);
    void UpdateUIPlayerCoins(float coins);
    void UpdateUICurrentStage(int newStage);
    void UpdateUICurrentLevelName(string newLevelName);
    void UpdateUICurrentEnemyName(string newName);
}
