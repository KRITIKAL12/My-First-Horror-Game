using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class WhereIsEveryone : MonoBehaviour
{
    public GameObject ThePlayer;
    public GameObject DialogueBox;
     
    void OnTriggerEnter()
    {
        this.GetComponent<BoxCollider>().enabled = false;
        ThePlayer.GetComponent<PlayerMovement>().enabled = false;
        StartCoroutine(WhereIs());
    }

    IEnumerator WhereIs ()
    {
        DialogueBox.GetComponent<Text>().text = "Why does it feel so quiet here? I wonder where everyone is...";

        yield return new WaitForSeconds(3.1f);
        DialogueBox.GetComponent<Text>().text = "";
        ThePlayer.GetComponent<PlayerMovement>().enabled = true;
    }

}
