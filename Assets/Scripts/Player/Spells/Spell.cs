using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Spell : ScriptableObject
{
    public string spellName;
    public string spellDescription;
    public float spellBaseDamage;
    protected float spellCurrentDamage;

    public TypeOfDamage typeOfDamage;

    public abstract void Use(EnemyBehaviour enemy);
}
