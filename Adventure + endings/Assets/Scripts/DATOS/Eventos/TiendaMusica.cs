using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class TiendaMusica : MonoBehaviour
{
    public GameObject display;
    
	void Start ()
    {
        if (DATOS.dia != 3)
        {
            gameObject.SetActive(false);
        }
        else { gameObject.SetActive(true); }
	}


    public void opcion1()
    {
        GameObject.FindGameObjectWithTag("PopUp").SetActive(true);
        GameObject.FindGameObjectWithTag("PopUp").GetComponent<PopUps>().SetMsg("My wife's favourites band. Would be good hearing it tonight.");
        DATOS.showing = true;
        DATOS.musicaComp = true;
        display.SetActive(false);
        gameObject.SetActive(false);
        DATOS.showing = false; 
    }

    public void opcion2()
    {
        GameObject.FindGameObjectWithTag("PopUp").SetActive(true);
        GameObject.FindGameObjectWithTag("PopUp").GetComponent<PopUps>().SetMsg("Not my favourite, but let's try something new.");
        DATOS.showing = true;
        DATOS.musicaComp = true;
        display.SetActive(false);
        gameObject.SetActive(false);
        DATOS.showing = false;
    }

    public void opcion3()
    {
        GameObject.FindGameObjectWithTag("PopUp").SetActive(true);
        GameObject.FindGameObjectWithTag("PopUp").GetComponent<PopUps>().SetMsg("Oooh for god's sake, finally it is released. I can't wait to get to home and hear it.");
        DATOS.showing = true;
        DATOS.musicaComp = true;
        display.SetActive(false);
        gameObject.SetActive(false);
        DATOS.showing = false;
    }
}
