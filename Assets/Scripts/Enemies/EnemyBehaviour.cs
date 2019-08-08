using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehaviour : MonoBehaviour
{

    public Enemy currentEnemy;

    public void SetupNewEnemy(Enemy newEnemy, float multiplier) {
        currentEnemy = newEnemy;
        
        //TODO: rework that
        currentEnemy.maxHealth = newEnemy.baseHealth * multiplier;
        currentEnemy.currentHealth = newEnemy.maxHealth;
    }

    public void GetDamage(float amount) {
       // SendMessage("PlayAnimation", "Hit");
        currentEnemy.currentHealth -= amount;
        if(currentEnemy.currentHealth <= 0) {
            Die();
        }
      //  SendMessage("PlayAnimation", "Idle");
    }

    public void Die() {
        //SendMessage("PlayAnimation", "Die");

        //Starting animation and wait until it ends
        //Need couroutine here

        //Sending message to placeholder
        SendMessage("EnemyIsDead");
    }
}
