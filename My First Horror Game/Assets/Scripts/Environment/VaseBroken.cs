using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VaseBroken : MonoBehaviour
{
    public GameObject fakeVase;
    public GameObject brokenVase;
    public GameObject sphereObject;




    public void BreakTheVase()
    {
        Debug.Log("Breaking the vase.");
        StartCoroutine(BreakVase());
    }

    IEnumerator BreakVase()
    {
        this.gameObject.GetComponent<BoxCollider>().enabled = false;
        fakeVase.SetActive(false);
        brokenVase.SetActive(true);
        yield return new WaitForSeconds(0.05f);
    }

}
