using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieDeath : MonoBehaviour
{
    public int EnemyHealth = 20;
    public GameObject TheEnemy;
    public int StatusCheck;

    void DamageZombie (int DamageAmount)
    {
        EnemyHealth -= DamageAmount;
    }



    // Update is called once per frame
    void Update()
    {
        if (EnemyHealth <= 0 && StatusCheck == 0)
        {
            StatusCheck = 2;
            TheEnemy.GetComponent<Animation>().Stop("Z_Walk");
            TheEnemy.GetComponent<Animation>().Play("Z_FallingBack");
        }
    }
}
