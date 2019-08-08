using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class UIControl : MonoBehaviour, IUIControl
{

    public Text coinsText;
    public Text currentStageText;
    public Text currentLevelNameText;
    public Slider enemyHealthbar;
    public Text enemyNameText;

    public SpriteRenderer enemySpriteRenderer;

    // Start is called before the first frame update
    void Start()
    {
        coinsText = GameObject.Find("CoinsText").GetComponent<Text>();
        currentStageText = GameObject.Find("StageText").GetComponent<Text>();
        currentLevelNameText = GameObject.Find("LevelNameText").GetComponent<Text>();
        enemyHealthbar = GameObject.Find("EnemyHealthBar").GetComponent<Slider>();
        enemySpriteRenderer = GameObject.Find("EnemyPlaceholder").GetComponent<SpriteRenderer>();
        enemyNameText = GameObject.Find("CurrentEnemyName").GetComponent<Text>();
    }

    public void UpdateUICurrentEnemyHealth(float maxHealth, float currentHealth)
    {
        enemyHealthbar.value = (currentHealth / maxHealth);
      /*/  Debug.Log($"{enemyHealthbar.value} is value of healthbar");
        Debug.Log($"{currentHealth} is currentHealth");
        Debug.Log($"{maxHealth} is maxHealth");
        Debug.Log($"{currentHealth/maxHealth} is division of current health and max health");*/
    }

    public void UpdateUIPlayerCoins(float coins)
    {
        coinsText.text = $"Coins: {coins}";
    }

    public void UpdateUICurrentEnemySprite(Sprite newEnemySprite)
    {
        enemySpriteRenderer.sprite = newEnemySprite;
    }

    public void UpdateUICurrentStage(int newStage)
    {
        currentStageText.text = $"Stage is {newStage}";
    }

    public void UpdateUICurrentLevelName(string newLevelName)
    {
        currentLevelNameText.text = newLevelName;
    }

    public void UpdateUICurrentEnemyName(string newName) 
    {
        enemyNameText.text = newName;
    }
}
