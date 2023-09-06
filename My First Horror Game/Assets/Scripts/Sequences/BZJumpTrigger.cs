using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BZJumpTrigger : MonoBehaviour
{
    public AudioSource DoorBang;
    public AudioSource DoorJumpMusic;
    public GameObject TheZombie;
    public GameObject TheDoor;

    void OnTriggerEnter()
    {
        GetComponent<BoxCollider>().enabled = false;
        TheDoor.GetComponent<Animation>().Play("JumpDoorAnim");
        DoorBang.Play();
        TheZombie.SetActive(true);
    }



}
