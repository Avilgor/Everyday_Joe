using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Medicina : MonoBehaviour
{
    
	void Start ()
    {
        if (DATOS.medicina == true)
        {
            gameObject.SetActive(false);
        }
    }

    public void comprada()
    {
        if (DATOS.darDinero)
        {
            GameObject.FindGameObjectWithTag("PopUp").SetActive(true);
            GameObject.FindGameObjectWithTag("PopUp").GetComponent<PopUps>().SetMsg("You don't have enough money to pay it.");
            DATOS.showing = true;
        }
        else
        {
            GameObject.FindGameObjectWithTag("PopUp").SetActive(true);
            GameObject.FindGameObjectWithTag("PopUp").GetComponent<PopUps>().SetMsg("This is the one I was looking for.");
            DATOS.showing = true;
        }
        DATOS.medicina = true;    
        gameObject.SetActive(false);
    }
}
