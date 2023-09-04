using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlameAnimation : MonoBehaviour
{
    public int LighMode;
    public GameObject flameLight;



    // Update is called once per frame
    void Update()
    {
        if (LighMode == 0)
        {
            StartCoroutine (AnimateLight());
           
        }
    }

    IEnumerator AnimateLight()
    {
        LighMode = Random.Range(1, 4);
        if (LighMode == 1)
        {
            flameLight.GetComponent<Animation>().Play("TorchAnim1");
        }
        if (LighMode == 1)
        {
            flameLight.GetComponent<Animation>().Play("TorchAnim2");
        }
        if (LighMode == 1)
        {
            flameLight.GetComponent<Animation>().Play("TorchAnim3");
        }
        yield return new WaitForSeconds(0.99f);
        LighMode = 0;
    }

}
