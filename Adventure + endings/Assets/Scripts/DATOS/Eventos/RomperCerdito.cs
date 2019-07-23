using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class RomperCerdito : MonoBehaviour
{
    public GameObject btn;

    private void Start()
    {
        if (DATOS.cerdito==true)
        {
            this.gameObject.SetActive(false);
        }
            
        if (DATOS.martillo == true)
        {
            btn.SetActive(true);
        }
        else
        {
            btn.SetActive(false);
        }
    }

    public void Romper()
    {
        GameObject.FindGameObjectWithTag("PopUp").SetActive(true);
        GameObject.FindGameObjectWithTag("PopUp").GetComponent<PopUps>().SetMsg("Bye piggy, I'll miss you buddy.");
        DATOS.showing = true;
        DATOS.cerdito = true;
        this.gameObject.SetActive(false);
    }
}
