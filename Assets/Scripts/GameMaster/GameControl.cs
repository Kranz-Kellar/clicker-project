using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControl : MonoBehaviour, IGameControl
{
    public List<Enemy> allEnemies;

    /*
    Rewrite with interface
     */
    private Player player;
    private IUIControl uiControl;
    private ILevelBehaviour level;
    public const float gameMultiplier = 1.07f;
    public int stageForChangeLevel = 10;
    
    IEnumerator Start()
    {
        player = GameObject.Find("Player").GetComponent<Player>();
        level = GameObject.Find("Level").GetComponent<LevelBehaviour>();
        uiControl = GetComponent<UIControl>();

        yield return new WaitForEndOfFrame();
        UpdateUI();
        

        yield return null;
    }

    private void EnemyClicked(EnemyBehaviour enemyInterface)
    {
        player.currentSpell.Use(enemyInterface);
        Debug.Log("Enemy was clicked");
        uiControl.UpdateUICurrentEnemyHealth(enemyInterface.currentEnemy.maxHealth, enemyInterface.currentEnemy.currentHealth);
    }

    private void UpdateUI() 
    {
        uiControl.UpdateUIPlayerCoins(player.playerCoins);
        uiControl.UpdateUICurrentStage(level.GetCurrentStage());
        uiControl.UpdateUICurrentLevelName(level.GetCurrentLevelInfo().levelName);
    }


    public Enemy GetNewEnemy()
    {
        return allEnemies[Random.Range(0, allEnemies.Count)];
    }

    public void RewardPlayer(Enemy deadEnemy)
    {
        player.playerCoins += Mathf.Round(deadEnemy.valueOfEnemy * GetCurrentGameMultiplier());
        uiControl.UpdateUIPlayerCoins(player.playerCoins);


        /*
            Shitty code
            Rewarding isn't changinge level stage or level itself
         */
        level.ChangeStage();
        uiControl.UpdateUICurrentStage(level.GetCurrentStage());
        
        //If current stage multiple by stage for change level 
        if(level.GetCurrentStage() % stageForChangeLevel == 0)
        {
            level.ChangeLevel();
            uiControl.UpdateUICurrentLevelName(level.GetCurrentLevelInfo().levelName);
        }
    }

    public float GetCurrentGameMultiplier() 
    {
        return Mathf.Pow(gameMultiplier, level.GetCurrentStage());
    }

}
