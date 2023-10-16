using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwingAxe : MonoBehaviour
{
    public GameObject TheAxe;
    public AudioSource SlashSound;
    public bool IsSlashing = false;
   

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            if (IsSlashing == false)
            {
                StartCoroutine(SwingingAxe());
            }
        }
    } 
   
    IEnumerator SwingingAxe()
    {
        IsSlashing = true;
        TheAxe.GetComponent<Animation>().Play("AxeAttack");
        SlashSound.Play();
        yield return new WaitForSeconds(0.5f);
        IsSlashing = false;
    }

}
