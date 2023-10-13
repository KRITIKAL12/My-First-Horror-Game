using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AxeCollision : MonoBehaviour
{
    public SwingAxe SwingAxe;
    public GameObject HitParticle;
    public int DamageAmount = 5;

    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Enemy" && SwingAxe.IsSlashing)
        {
            Debug.Log("Axe collision with enemy.");
            Vector3 particlePosition = other.transform.position + (transform.position - other.transform.position) * 0.5f;
            Instantiate(HitParticle, particlePosition, other.transform.rotation);

            EnemyHealth enemyHealth = other.GetComponent<EnemyHealth>();

            // Check if the enemy has the EnemyHealth component
            if (enemyHealth != null)
            {
                Debug.Log("Dealing damage to the enemy.");
                // Call a method to apply damage to the enemy
                enemyHealth.TakeDamage(DamageAmount);
            }
        }
    }


}
