using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowControls : MonoBehaviour
{
    public void Controles()
    {
        GameObject.FindGameObjectWithTag("PopUp").SetActive(true);
        GameObject.FindGameObjectWithTag("PopUp").GetComponent<PopUps>().SetMsg("Espace Bar - Leave Object." +
            "\nEscape - Pause game." +
            "\nMouse - Selection.");
        DATOS.showing = true;
    }
}