using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Data", menuName = "SO/Enemy", order = 1)]
public class Enemy : ScriptableObject
{

    public string enemyName;
    public string enemyDescription;
    public long valueOfEnemy;
    public float baseHealth;
    public float currentHealth;
    public float maxHealth;
    public Sprite enemySprite;
}
