using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KeyPickup : MonoBehaviour
{
    public float TheDistance;
    public GameObject ActionDisplay;
    public GameObject ActionText;
    public GameObject ExtraCross;
    public GameObject Zombie;
    public GameObject theKey;
    public GameObject LockedDoor;
    public GameObject ExitTrigger;

    // Update is called once per frame
    void Update()
    {
        TheDistance = PlayerCasting.DistanceFromTarget;
    }

    void OnMouseOver()
    {
        if (TheDistance <= 2)
        {
            ExtraCross.SetActive(true);
            ActionText.GetComponent<Text>().text = "Pick up Key";
            ActionDisplay.SetActive(true);
            ActionText.SetActive(true);
           
        }   
        if (Input.GetButtonDown("Action"))
        {
            if (TheDistance <= 2)
            {
                this.GetComponent<BoxCollider>().enabled = false;
                ActionDisplay.SetActive(false);
                ActionText.SetActive(false);
                ExtraCross.SetActive(false);
                theKey.SetActive(false);
                LockedDoor.SetActive(false);
                ExitTrigger.SetActive(true);
                GlobalInventory.firstDoorKey = true;
                StartCoroutine(DoorReset());
                
            }
        }
    }

    void OnMouseExit()
    {
        ExtraCross.SetActive(false);
        ActionDisplay.SetActive(false);
        ActionText.SetActive(false);
    }

    IEnumerator DoorReset()
    {
       
         yield return new WaitForSeconds(1);
         Zombie.SetActive(true);
    }

}
