using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EveryDayThink : MonoBehaviour
{
    private void Start()
    {
        switch (DATOS.dia)
        {
            case 1:
                if (DATOS.wakeUp == false)
                {
                    GameObject.FindGameObjectWithTag("PopUp").SetActive(true);
                    GameObject.FindGameObjectWithTag("PopUp").GetComponent<PopUps>().SetMsg("I've been sleeping for too long again, she's already gone." +
                                                "If I remember correctly she left me a note with chores to do." +
                                                "It should be over the bedside table.");
                    DATOS.showing = true;
                }
                break;
            case 2:
                if (DATOS.wakeUp == false)
                {
                    GameObject.FindGameObjectWithTag("PopUp").SetActive(true);
                    GameObject.FindGameObjectWithTag("PopUp").GetComponent<PopUps>().SetMsg("Another day another paper with chores. " +
                        "There’s something to love and something to hate about routine.");
                    DATOS.showing = true;
                }
                break;
            case 3:
                if (DATOS.wakeUp == false)
                {
                    GameObject.FindGameObjectWithTag("PopUp").SetActive(true);
                    GameObject.FindGameObjectWithTag("PopUp").GetComponent<PopUps>().SetMsg("Oh hello there Mr.Piece of paper, did you miss me?");
                    DATOS.showing = true;
                }
                break;
        }
    }
}
