using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Data", menuName = "SO/Spell/DamageSpell", order = 1)]
public class DamageSpell : Spell
{
    public override void Use(EnemyBehaviour enemy)
    {
        enemy.GetDamage(this.spellBaseDamage);
    }
}
