using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArticuloCompra : MonoBehaviour
{
    public GameObject[] botones;
	
	void Start ()
    {
        if (DATOS.huevos == true)
        {
            botones[0].SetActive(false);
        }

        if (DATOS.leche == true)
        {
            botones[1].SetActive(false);
        }

        if (DATOS.verdura == true)
        {
            botones[2].SetActive(false);
        }
    }

    public void huevos()
    {
        DATOS.compra = true;
        DATOS.huevos = true;
        botones[0].SetActive(false);
        GameObject.FindGameObjectWithTag("PopUp").SetActive(true);
        GameObject.FindGameObjectWithTag("PopUp").GetComponent<PopUps>().SetMsg("White and oval-shaped, just how i like them.");
        DATOS.showing = true;
    }

    public void verduras()
    {
        DATOS.compra = true;
        DATOS.verdura = true;
        botones[2].SetActive(false);
        GameObject.FindGameObjectWithTag("PopUp").SetActive(true);
        GameObject.FindGameObjectWithTag("PopUp").GetComponent<PopUps>().SetMsg("Good ol' vegetables, remember to eat your greens kids.");
        DATOS.showing = true;
    }

    public void leche()
    {
        DATOS.compra = true;
        DATOS.leche = true;
        botones[1].SetActive(false);
        GameObject.FindGameObjectWithTag("PopUp").SetActive(true);
        GameObject.FindGameObjectWithTag("PopUp").GetComponent<PopUps>().SetMsg("Drink milk and get big bones.");
        DATOS.showing = true;
    }
}
