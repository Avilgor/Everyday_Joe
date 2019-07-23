using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Vagabundo : MonoBehaviour
{
    public GameObject btnRev;
    public GameObject display;

    void Start()
    {
        if (DATOS.revista == true)
        {
            btnRev.SetActive(true);
        }
        else
        {
            btnRev.SetActive(false);
        }

        if (DATOS.vagabundo == true)
        {
            this.gameObject.SetActive(false);
        }           
    }

    public void contarlo()
    {
        GameObject.FindGameObjectWithTag("PopUp").SetActive(true);
        GameObject.FindGameObjectWithTag("PopUp").GetComponent<PopUps>().SetMsg("You tell what happened to the suited man.");
        DATOS.showing = true;
        DATOS.vagabundo = true;
        DATOS.vagbundoDecision = 1;
        this.gameObject.SetActive(false);
        display.SetActive(false);
        DATOS.showing = false;
    }

    public void callarse()
    {
        GameObject.FindGameObjectWithTag("PopUp").SetActive(true);
        GameObject.FindGameObjectWithTag("PopUp").GetComponent<PopUps>().SetMsg("You don’t say anything.");
        DATOS.showing = true;
        DATOS.vagabundo = true;
        DATOS.vagbundoDecision = 2;
        this.gameObject.SetActive(false);
        display.SetActive(false);
        DATOS.showing = false;
    }

    public void ayudar()
    {
        GameObject.FindGameObjectWithTag("PopUp").SetActive(true);
        GameObject.FindGameObjectWithTag("PopUp").GetComponent<PopUps>().SetMsg("You tell the homeless man to take profit of it and expend it on the offer that’s going" +                                    "on in the supermarket.");
        DATOS.showing = true;
        DATOS.vagabundo = true;
        DATOS.vagbundoDecision = 3;
        this.gameObject.SetActive(false);
        display.SetActive(false);
        DATOS.showing = false;
    }
}