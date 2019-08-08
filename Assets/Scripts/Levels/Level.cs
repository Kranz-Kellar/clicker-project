using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Data", menuName = "SO/Level", order = 1)]
public class Level : ScriptableObject
{
    public string levelName;
    public string levelDescription;
    public GameObject levelBackgroundPrefab;
}
