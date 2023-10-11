using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PickUpAxe : MonoBehaviour
{
    public float TheDistance;
    public GameObject ActionDisplay;
    public GameObject ActionText;
    public GameObject FakeAxe;
    public GameObject RealAxe;
    public GameObject ExtraCross;
    public GameObject ZombieInside;


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
            ActionText.GetComponent<Text>().text = "Pick Up Axe";
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
                FakeAxe.SetActive(false);
                RealAxe.SetActive(true);
                ExtraCross.SetActive(false);
                ZombieInside.SetActive(true);

            }
        }
    }

    void OnMouseExit()
    {
        ExtraCross.SetActive(false);
        ActionDisplay.SetActive(false);
        ActionText.SetActive(false);
    }

}
