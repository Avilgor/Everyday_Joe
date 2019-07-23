using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Orfanato : MonoBehaviour
{
    public GameObject display;
    public GameObject[] botones;

	void Start ()
    {
        if (DATOS.dia == 3 && DATOS.compra == true)
        {
            if (DATOS.orfanato == true)
            {
                gameObject.SetActive(false);
            }
            else
            {
                gameObject.SetActive(true);
            }         
        }
        else { gameObject.SetActive(false); }
	}

    public void policia()
    {
        display.SetActive(false);
        DATOS.showing = false;
        DATOS.orfPolicia = true;
        DATOS.orfanato = true;
        gameObject.SetActive(false);
    }

    public void seguir()
    {
        botones[0].SetActive(false);
        botones[1].SetActive(false);
        botones[2].SetActive(true);
        botones[3].SetActive(true);
        GameObject.FindGameObjectWithTag("PopUp").SetActive(true);
        GameObject.FindGameObjectWithTag("PopUp").GetComponent<PopUps>().SetMsg("The man you where following get into an orphanage and left the food there." +
                                            "What do you do?");
        DATOS.showing = true;
        gameObject.SetActive(false);
    }

    public void ocultarlo()
    {
        display.SetActive(false);
        DATOS.showing = false;
        DATOS.orfAyudar = true;
        DATOS.orfanato = true;
        gameObject.SetActive(false);
        gameObject.SetActive(false);
    }
}