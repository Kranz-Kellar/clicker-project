using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelBehaviour : MonoBehaviour, ILevelBehaviour
{
    public List<Level> allLevels;
    public int levelStage = 1;
    public Level currentLevel;

    private void Start()
    {
        ChangeLevel(); 
    }

    public void ChangeLevel()
    {
        currentLevel = allLevels[Random.Range(0, allLevels.Count)];
    }

    public void ChangeStage()
    {
       levelStage++;
    }   

    public int GetCurrentStage()
    {
        return levelStage;
    }

    public Level GetCurrentLevelInfo() 
    {
        return currentLevel;
    }
    
}
