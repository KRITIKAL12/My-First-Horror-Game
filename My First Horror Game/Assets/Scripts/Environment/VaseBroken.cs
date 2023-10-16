using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VaseBroken : MonoBehaviour
{
    public GameObject fakeVase;
    public GameObject brokenVase;
    public GameObject sphereObject;
    public GameObject ExtraCross;
    public float TheDistance;
    public AudioSource potteryBreak;

    void Update()
    {
        TheDistance = PlayerCasting.DistanceFromTarget;
    }

    public void BreakTheVase()
    {
        Debug.Log("Breaking the vase.");
        StartCoroutine(BreakVase());
    }

    void OnMouseOver()
    {
        if (TheDistance <= 2)
        {
            ExtraCross.SetActive(true);
          

        }
        if (Input.GetButtonDown("Action"))
        {
            if (TheDistance <= 2)
            {
          
                ExtraCross.SetActive(false);
             

            }
        }
    }

    void OnMouseExit()
    {
        ExtraCross.SetActive(false);
    
    }



    IEnumerator BreakVase()
    {
        this.gameObject.GetComponent<BoxCollider>().enabled = false;
        potteryBreak.Play();
        fakeVase.SetActive(false);
        brokenVase.SetActive(true);
        ExtraCross.SetActive(false);
        yield return new WaitForSeconds(0.05f);
        sphereObject.SetActive(true);
        yield return new WaitForSeconds(0.05f);
        sphereObject.SetActive(false);

    }

}
