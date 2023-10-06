using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.Rendering.PostProcessing;

public class StalkerAI : MonoBehaviour
{
    public GameObject stalkerDest;
    NavMeshAgent stalkerAgent;
    public GameObject stalkerEnemy;
    public static bool isStalking;
    public bool attackTrigger = false;
    public bool isAttacking = false;
    public AudioSource hurtSound1;
    public AudioSource hurtSound2;
    public AudioSource hurtSound3;
    public int hurtGen;
    public GameObject theFlash;

    public PostProcessProfile postProcessProfile;

    private ChromaticAberration chromaticAberrationEffect;

    void Start()
    {
        stalkerAgent = GetComponent<NavMeshAgent>();
        chromaticAberrationEffect = postProcessProfile.GetSetting<ChromaticAberration>();
    }

 
    void Update()
    {


        if (isStalking == false)
        {
            stalkerEnemy.GetComponent<Animator>().Play("Z_Idle");
        }
        else
        {
            stalkerEnemy.GetComponent<Animation>().Play("Z_Walk_InPlace");
            stalkerAgent.SetDestination(stalkerDest.transform.position);
            chromaticAberrationEffect.intensity.value = 0f;
        }

        // Check for attack trigger
        if (attackTrigger == true && isAttacking == false)
        {

            stalkerEnemy.GetComponent<Animation>().Play("Z_Attack");
            stalkerAgent.isStopped = true;
            StartCoroutine(InflictDamage());

            chromaticAberrationEffect.intensity.value = 1f;
        }
        else
        {
            stalkerAgent.isStopped = false;
        }

    }

    void OnTriggerEnter()
    {
        attackTrigger = true;
    }

    void OnTriggerExit()
    {
        attackTrigger = false;
    }

    IEnumerator InflictDamage()
    {
        isAttacking = true;
        hurtGen = Random.Range(1, 4);
        if (hurtGen == 1)
        {
            hurtSound1.Play();
        }
        if (hurtGen == 2)
        {
            hurtSound2.Play();
        }
        if (hurtGen == 3)
        {
            hurtSound3.Play();
        }
        theFlash.SetActive(true);
        yield return new WaitForSeconds(0.1f);
        theFlash.SetActive(false);

        yield return new WaitForSeconds(1.1f);
        GlobalHealth.currentHealth -= 5;

        yield return new WaitForSeconds(1f);
        isAttacking = false;

        chromaticAberrationEffect.intensity.value = 0f;

    }
}
