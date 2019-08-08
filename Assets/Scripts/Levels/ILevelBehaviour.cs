using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ILevelBehaviour
{
    void ChangeLevel();
    void ChangeStage();

    int GetCurrentStage();

    Level GetCurrentLevelInfo();
}
