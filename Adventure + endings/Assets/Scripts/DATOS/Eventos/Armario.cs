using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Armario : MonoBehaviour
{
    public void vestir()
    {
        if (DATOS.vestido)
        {
            GameObject.FindGameObjectWithTag("PopUp").SetActive(true);
            GameObject.FindGameObjectWithTag("PopUp").GetComponent<PopUps>().SetMsg("I'm already dressed.");
            DATOS.showing = true;
        }
        else
        {
            switch (DATOS.dia)
            {
                case 1:
                    GameObject.FindGameObjectWithTag("PopUp").SetActive(true);
                    GameObject.FindGameObjectWithTag("PopUp").GetComponent<PopUps>().SetMsg("It's my favourite outfit, that's why it's my only outfit.");
                    DATOS.showing = true;
                    break;
                case 2:
                    GameObject.FindGameObjectWithTag("PopUp").SetActive(true);
                    GameObject.FindGameObjectWithTag("PopUp").GetComponent<PopUps>().SetMsg("Yeah, I look nice because I am nice as frick boy!");
                    DATOS.showing = true;
                    break;
                case 3:
                    GameObject.FindGameObjectWithTag("PopUp").SetActive(true);
                    GameObject.FindGameObjectWithTag("PopUp").GetComponent<PopUps>().SetMsg("For my wedding I'll have to change clothes, damn.");
                    DATOS.showing = true;
                    break;
            }
            DATOS.vestido = true;
        }
    }
}