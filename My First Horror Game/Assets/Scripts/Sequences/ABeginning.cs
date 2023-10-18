using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ABeginning : MonoBehaviour
{
    public GameObject ThePlayer;
    public GameObject FadeScreenIn;
    public GameObject TextBox;
    private Animation textBoxAnimation;

    void Start()
    {
        ThePlayer.GetComponent<PlayerMovement>().enabled = false;
        textBoxAnimation = TextBox.GetComponent<Animation>();
        StartCoroutine(ScenePlayer());
    }

    IEnumerator ScenePlayer()
    {
        yield return new WaitForSeconds(3);
        TextBox.SetActive(true);
        textBoxAnimation.Play("Beginning text Animation");

        yield return new WaitForSeconds(27);
        TextBox.GetComponent<Text>().text = "";
        FadeScreenIn.SetActive(false);
        ThePlayer.GetComponent<PlayerMovement>().enabled = true;

    }
}
