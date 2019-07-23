using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Martillo : MonoBehaviour
{
    public GameObject martillo;
    private void Start()
    {
        if (DATOS.martillo == true)
        {
            martillo.SetActive(false);
        }
    }

    public void cogerMartillo()
    {
        GameObject.FindGameObjectWithTag("PopUp").SetActive(true);
        GameObject.FindGameObjectWithTag("PopUp").GetComponent<PopUps>().SetMsg("What can I obliterate with my mighty hammer of doom?");
        DATOS.showing = true;
        DATOS.martillo = true;
        martillo.SetActive(false);
    }
}
