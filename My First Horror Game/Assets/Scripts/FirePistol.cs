using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirePistol : MonoBehaviour
{
    public GameObject TheGun;
    public GameObject MuzzleFlash;
    public AudioSource GunFire;
    public Light MuzzleFlashLight;
    public bool IsFiring = false;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            if (IsFiring == false)
            {
                StartCoroutine(FiringPistol());
            }
        }
    }

    IEnumerator FiringPistol ()
    {
        IsFiring = true;
        TheGun.GetComponent<Animation>().Play("PistolShot");
        MuzzleFlash.SetActive(true);
        MuzzleFlash.GetComponent<Animation>().Play("MuzzleAnim");
        GunFire.Play();

        MuzzleFlashLight.enabled = true;

        yield return new WaitForSeconds(0.5f);
        MuzzleFlashLight.enabled = false;
        IsFiring =false;
    }

}
