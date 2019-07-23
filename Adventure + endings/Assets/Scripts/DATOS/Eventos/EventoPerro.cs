using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class EventoPerro : MonoBehaviour
{   
    public void tocar()
    {
        GameObject.FindGameObjectWithTag("PopUp").SetActive(true);
        GameObject.FindGameObjectWithTag("PopUp").GetComponent<PopUps>().SetMsg("You pet the dog, nobody can stop you, you only live once.");
        DATOS.showing = true;
        DATOS.perro = true;
        DATOS.perroDone = true;
        this.gameObject.SetActive(false);
        DATOS.showing = false;
    }

    public void irse()
    {
        GameObject.FindGameObjectWithTag("PopUp").SetActive(true);
        GameObject.FindGameObjectWithTag("PopUp").GetComponent<PopUps>().SetMsg("You can’t go there petting random dogs on the street, maybe its owner bites..");
        DATOS.showing = true;
        DATOS.perroDone = true;
        this.gameObject.SetActive(false);
        DATOS.showing = false;
    }
}