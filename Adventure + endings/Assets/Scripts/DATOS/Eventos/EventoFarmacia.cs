using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventoFarmacia : MonoBehaviour
{
    public GameObject display;

	void Start ()
    {
        if (DATOS.dia == 2)
        {
            if (DATOS.eventoFarmacia == false)
            {
                gameObject.SetActive(true);
            }
            else { gameObject.SetActive(false); }
        }
        else { gameObject.SetActive(false); }
    }

    public void esperar()
    {
        display.SetActive(false);
        DATOS.showing = false;
        DATOS.eventoFarmacia = true;
        gameObject.SetActive(false);
    }

    public void hombre()
    {
        DATOS.hombreMed = true;
        display.SetActive(false);
        DATOS.showing = false;
        DATOS.eventoFarmacia = true;
        gameObject.SetActive(false);
    }

    public void famaceutico()
    {
        DATOS.farmaceutico = true;
        display.SetActive(false);
        DATOS.showing = false;
        DATOS.eventoFarmacia = true;
        gameObject.SetActive(false);
    }

    public void dinero()
    {
        DATOS.darDinero = true;
        display.SetActive(false);
        DATOS.showing = false;
        DATOS.eventoFarmacia = true;
        gameObject.SetActive(false);
    }
}