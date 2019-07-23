using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ttxNota : MonoBehaviour
{
    public Text txt;

	void Start ()
    {
        switch (DATOS.dia)
        {
            case 1:
                txt.text= "-To do list-\n"+
                            "-Buy medicine\n" +
                              "Neat, that would help my partner recover from his cold.\n" +
                            "-Buy eggs\n" +
                              "White and oval-shaped, just how i like them.\n" +
                            "-Buy vegetables\n" +
                              "Good - ol vegetables, remember to eat your greens kids.\n" +
                            "-Buy milk\n" +
                              "Drink milk and stay hydrated.\n" +
                            "-Prepare dinner\n\n" +

                            "After that you’ll have free time\n" +
                            "(don’t forget your clothes)\n" +
                            "xoxo";
                    break;
            case 2:
                txt.text = "-To do list-\n" +
                            "-Buy medicine\n" +
                              "The same one as yesterday.\n" +
                            "-Buy eggs\n" +
                              "Raising cholesterol.\n" +
                            "-Buy vegetables\n" +
                              "Good for fitness.\n" +
                            "-Buy milk\n" +
                              "Use it for the dinner.\n" +
                            "-Prepare dinner\n\n" +

                            "After that you can do as you please\n" +                           
                            "See you soon honey <3";
                break;

            case 3:
                txt.text = "-To do list-\n" +
                            "-Buy medicine" +
                              "How many more days I need of this?\n" +
                            "-Buy eggs\n" +
                              "Only a few, not 12 as usually.\n" +
                            "-Buy vegetables\n" +
                              "The greener, the better.\n" +
                            "-Buy milk\n" +
                              "Put it on the fridge.\n" +
                            "-Prepare dinner\n\n" +

                            "Love you honey\n" +
                            "I'll have good news tonight";
                break;

        }
	}	
}