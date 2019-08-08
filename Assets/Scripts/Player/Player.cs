using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public string playerName;
    public float playerDamagePerTick;
    public float playerDamagePerClick;
    public float playerCoins;
    public List<GameObject> playerEnhancements;
    public List<Spell> playerSpells;
    public Spell currentSpell;
}
