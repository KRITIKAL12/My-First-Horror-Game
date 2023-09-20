using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AOpening : MonoBehaviour
{
    public GameObject ThePlayer;
    public GameObject FadeScreenIn;
    public GameObject TextBox;
    public AudioSource Line01;
    public AudioSource Line02;

    void Start()
    {
        ThePlayer.GetComponent<PlayerMovement>().enabled = false;
        StartCoroutine(ScenePlayer());
    }

   IEnumerator ScenePlayer()
    {
        yield return new WaitForSeconds(1.5f);
        FadeScreenIn.SetActive (false);
        TextBox.GetComponent <Text> ().text = "...where am I?";
        Line01.Play();
        yield return new WaitForSeconds(2);
        TextBox.GetComponent<Text>().text = "";
        yield return new WaitForSeconds(0.5F);
        TextBox.GetComponent<Text>().text = "I need to get out of here.";
        Line02.Play();
        yield return new WaitForSeconds(1.7f);
        TextBox.GetComponent<Text>().text = "";
        ThePlayer.GetComponent<PlayerMovement>().enabled = true;
    }
}
