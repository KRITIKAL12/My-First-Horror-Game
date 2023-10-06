using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class StalkerAI : MonoBehaviour
{
    public GameObject stalkerDest;
    NavMeshAgent stalkerAgent;
    public GameObject stalkerEnemy;
    public static bool isStalking;

    void Start()
    {
        stalkerAgent = GetComponent<NavMeshAgent>();
    }

 
    void Update()
    {
        if (isStalking == false)
        {
            stalkerEnemy.GetComponent<Animator>().Play("Z_Idle");
        }
        else
        {
            stalkerEnemy.GetComponent<Animator>().Play("Z_Walk_InPlace");
            stalkerAgent.SetDestination(stalkerDest.transform.position);
        }

    }
}
