using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DaySwitcher : MonoBehaviour
{
    //public GameObject[] objetos;
    public int dia;
    ColorBlock cb;

    void Start()
    {                   
        if (DATOS.dia != dia)
        {
            try
            {
                cb = gameObject.GetComponent<Button>().colors;
                cb.colorMultiplier = 2;
                gameObject.GetComponent<Button>().colors = cb;
                gameObject.GetComponent<Button>().interactable = false;
            }
            catch (Exception e)
            {

            }          
        }
        /*switch (DATOS.dia)
        {
            case 1:
                objetos[1].
                break;
            case 2:
                break;
            case 3:
                break;
        }*/
	}
}