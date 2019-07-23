using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class btnInteractive : MonoBehaviour
{
    private bool on=false;
    [SerializeField]
    public GameObject Display;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && on==true)
        {
            on = false;
            DATOS.showing = false;
            Display.SetActive(false);            
        }
    }

    public void show()
    {
        if (on==false && DATOS.showing==false)
        {
            DATOS.showing = true;
            on = true;
            Display.SetActive(true);
        }
    }


    public void showNota()
    {
        if (on == false && DATOS.showing == false)
        {
            DATOS.showing = true;
            DATOS.nota = true;
            on = true;
            Display.SetActive(true);
        }
    }
}