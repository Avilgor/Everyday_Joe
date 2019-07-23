using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Cocinar : MonoBehaviour
{
    void Start()
    {
        if (DATOS.compra == true && DATOS.medicina)
        {
            if (DATOS.cocinarDone == false)
            {
                gameObject.SetActive(true);
            }
        }
        else
        {
            gameObject.SetActive(false);
        }

    }

    public void hacerComida()
    {
        DATOS.cocinarDone = true;
        DATOS.comida = true;
        DATOS.showing = false;
        if (DATOS.dia == 2)
        {
            GameObject.FindGameObjectWithTag("PopUp").SetActive(true);
            GameObject.FindGameObjectWithTag("PopUp").GetComponent<PopUps>().SetMsg("You find a delicious plate of potato salad, it’s not fancy but it’s your favorite meal." +
                                        "Where your serviette should be there’s a note. You read it:" +
                                        "   -Honey, I know we almost don’t see each other, that the biggest interaction that we have everyday " +
                                        "    is the chore list. But I have good news. They’re promoting me. We will have more time together " +
                                        "    from this weekend on. " +
                                        "I’m going to sleep, I hope you enjoy this meal < 3." +
                                        "Those are great news, you can’t wait for the weekend to arrive.\n");
            DATOS.showing = true;
        }
        if (DATOS.cantCompra == 1)
        {
            GameObject.FindGameObjectWithTag("PopUp").SetActive(true);
            GameObject.FindGameObjectWithTag("PopUp").GetComponent<PopUps>().SetMsg("Your food has the same flavour as a rock.");
            DATOS.showing = true;
        }
        if (DATOS.cantCompra == 2)
        {
            GameObject.FindGameObjectWithTag("PopUp").SetActive(true);
            GameObject.FindGameObjectWithTag("PopUp").GetComponent<PopUps>().SetMsg("It's not the best, but atleast you have something to eat...");
            DATOS.showing = true;
        }
        if (DATOS.cantCompra == 3)
        {
            GameObject.FindGameObjectWithTag("PopUp").SetActive(true);
            GameObject.FindGameObjectWithTag("PopUp").GetComponent<PopUps>().SetMsg("You feel like a chef and you have prepared a god's dinner.");
            DATOS.showing = true;
        }
        this.gameObject.SetActive(false);
    }

    public void noCocinar()
    {
        DATOS.cocinarDone = true;
        DATOS.showing = false;
        this.gameObject.SetActive(false);
    }
}