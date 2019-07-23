using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEditor;

public class OnEnterPlace : MonoBehaviour
{	
	void Start ()
    {
        int indice = SceneManager.GetActiveScene().buildIndex;
        switch (indice)
        {
            case 13:
                if (DATOS.sotano == false)
                {
                    GameObject.FindGameObjectWithTag("PopUp").SetActive(true);
                    GameObject.FindGameObjectWithTag("PopUp").GetComponent<PopUps>().SetMsg("It’s been a lot since I last entered here, who knows what I might find.");
                    DATOS.showing = true;
                    DATOS.sotano = true;
                }
                break;
            case 10:
                if (DATOS.super == false)
                {
                    GameObject.FindGameObjectWithTag("PopUp").SetActive(true);
                    GameObject.FindGameObjectWithTag("PopUp").GetComponent<PopUps>().SetMsg("A mall is a place where you can exchange your currency for goods and services," +
                                                "just what you need to get all the items on the list. It sounds a nice tune in the place," +
                                                "but all the chill vibes get destroyed when you see the line to check-out." +
                                                 "What would you like to buy ?");
                    DATOS.showing = true;
                    DATOS.super = true;
                }break;
            case 9:
                if (DATOS.farmacia == false)
                {
                    GameObject.FindGameObjectWithTag("PopUp").SetActive(true);
                    GameObject.FindGameObjectWithTag("PopUp").GetComponent<PopUps>().SetMsg("A pharmacy is an interesting place. People can buy what they need to fight any illness," +
                                                "they can buy anticonceptives or they could buy a bottle of “MAGIC FORMULA TO LOSE WEIGHT IN 3 WEEKS" +
                                                "BY THE PROFESSOR REGADERA”. " + "" +
                                                "You’ll just take the meds your special one needs, no need to get pooping potion.");
                    DATOS.showing = true;
                    DATOS.farmacia = true;
                }
                break;
        }
        
	}
}