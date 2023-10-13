using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public int maxHealth = 20;
    private int currentHealth;
    public GameObject TheEnemy;
    public int StatusCheck;
    public AudioSource JumpScareMusic;
    public AudioSource AmbMusic;

    private bool isAlive = true; // Property to determine if the enemy is alive

    public bool IsAlive
    {
        get { return isAlive; }
    }

    // Method to apply damage to the enemy
    public void TakeDamage(int damage)
    {
        Debug.Log("Enemy health reduced to: " + maxHealth);
        maxHealth -= damage;

    }

    void Update()
    {
        if (maxHealth <= 0 && StatusCheck == 0)
        {
            isAlive = false;
            Debug.Log("Enemy died.");
            // Add code to handle enemy death (e.g., play death animation, deactivate GameObject)
            // For example:
            this.GetComponent<StalkerAI>().enabled = false;
            this.GetComponent<BoxCollider>().enabled = false;
            StatusCheck = 2;
            TheEnemy.GetComponent<Animation>().Stop("Z_Walk_InPlace");
            TheEnemy.GetComponent<Animation>().Play("Z_FallingBack");

            JumpScareMusic.Stop();
            AmbMusic.Play();
        }
    }
}