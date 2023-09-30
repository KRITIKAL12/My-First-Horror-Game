using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ABeginning : MonoBehaviour
{
    public GameObject ThePlayer;
    public GameObject FadeScreenIn;
    public GameObject TextBox;
    

    void Start()
    {
        ThePlayer.GetComponent<PlayerMovement>().enabled = false;
        StartCoroutine(ScenePlayer());
    }

    IEnumerator ScenePlayer()
    {
        yield return new WaitForSeconds(1.5f);
        TextBox.GetComponent<Text>().text = "...where am I?";
     
        yield return new WaitForSeconds(2);
        TextBox.GetComponent<Text>().text = "";
        yield return new WaitForSeconds(0.5F);
        TextBox.GetComponent<Text>().text = "I need to get out of here.";

        yield return new WaitForSeconds(1.7f);
        TextBox.GetComponent<Text>().text = "";
        ThePlayer.GetComponent<PlayerMovement>().enabled = true;

        FadeScreenIn.SetActive(false);
    }
}
