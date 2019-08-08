using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaceholderBehaviour : MonoBehaviour
{

    SpriteRenderer spriteRenderer;
    Animator animator;
    EnemyBehaviour enemyBehaviour;
    IGameControl gameControl;
    IUIControl uiControl;

    // Start is called before the first frame update
    void Start()
    {
        //animator = GetComponent<Animator>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        enemyBehaviour = GetComponent<EnemyBehaviour>();
        gameControl = GameObject.Find("GameMaster").GetComponent<GameControl>();
        uiControl = GameObject.Find("GameMaster").GetComponent<UIControl>();

        SetCurrentEnemy();
    }

    void SetCurrentEnemy()
    {
        Enemy enemy = gameControl.GetNewEnemy();
        if (enemy != null)
        {
            enemyBehaviour.SetupNewEnemy(enemy, gameControl.GetCurrentGameMultiplier());
            //Updating UI here
            uiControl.UpdateUICurrentEnemyHealth(enemyBehaviour.currentEnemy.maxHealth, enemyBehaviour.currentEnemy.currentHealth);
            uiControl.UpdateUICurrentEnemySprite(enemy.enemySprite);
            uiControl.UpdateUICurrentEnemyName(enemy.enemyName);
        }
        else
        {
            Debug.LogError("GameControl.GetRandomEnemy() returns null!");
        }
    }

    void EnemyIsDead()
    {
        gameControl.RewardPlayer(enemyBehaviour.currentEnemy);
        SetCurrentEnemy();
    }

    void PlayAnimation(string animationName) 
    {
        //animator.Play(animationName, -1);
    }
}
