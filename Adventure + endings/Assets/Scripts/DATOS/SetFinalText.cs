using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetFinalText : MonoBehaviour
{
    public Text[] textos;

	void Start ()
    {
        if (DATOS.vagbundoDecision == 1)
        {
            textos[0].text = "The homeless man got a bad reputation, he got even less money. He'll live less than 2 months. ";
        }
        else if(DATOS.vagbundoDecision == 2)
        {
            textos[0].text = "The homeless man got booze trying to forget about his reality, he ended in jail for a fight and, well, he lives better than before.";
        }
        else if (DATOS.vagbundoDecision == 3)
        {
            textos[0].text = "The homeless man found a job offer for product testing when buying food, this helped him earn some income and make friends.";
        }
        else
        {
            textos[0].text = "You won't know what happened on the streets this time.";
        }

        ////////////////////////

        if (DATOS.hombreMed == true)
        {
            textos[1].text = "The old man thought he was right, so he tried to get the pills by force a couple of days later. They called the police on him and gave him a fine.";
        }
        else if (DATOS.farmaceutico == true)
        {
            textos[1].text = "The old man felt defeated and decided to stay at home with his wife.";
        }
        else if (DATOS.darDinero == true)
        {
            textos[1].text = "The wife of the man felt a little better. Her illness wasn't going away but at least she suffered a little less.";
        }
        else
        {
            textos[1].text = "Things happened at the pharmacy, but it does not matter you.";
        }

        ///////////////////////////

        if (DATOS.llamadas == 1)
        {
            textos[2].text = "Your mother knew about your death a day later, she grieved.";
        }
        else if (DATOS.llamadas == 2)
        {
            textos[2].text = "Your mother was called the same night to know about your death. She met with your fiance to prepare your funeral.";
        }
        else if (DATOS.llamadas == 3)
        {
            textos[2].text = "Your mother grieved a lot, she loved you a lot and tried to help your fiance go through everything.";
        }
        else if (DATOS.llamadas >= 2 && DATOS.musicaComp == true)
        {
            textos[2].text = "They told your mom about the album. She got thankful for the good son that you were and listened to the vynil everyday";
        }
        else
        {
            textos[2].text = "Your mom was told a few weeks later that you died. She cried the whole night.";
        }

        ///////////////////////////

        if (DATOS.perro == true)
        {
            textos[3].text = "The dog you caressed lived happily ever after, like a good doggo.";
        }
        if (DATOS.perro == false)
        {
            textos[3].text = "You regret not petting that dog, it looked soft, damn.";
        }

        if (DATOS.teatro == true)
        {
            textos[4].text = "Your special one received the tickets and kept them in the living room as a memoir of love";
        }
        if (DATOS.teatro == false)
        {
            textos[4].text = "You did not know it, but your special one bought tickets to the theater. She threw them and never went to a theater again.";
        }
        //////////////////////
        textos[5].text = "Well, the dilemma of this game is not obvious because almost everybody faces it unknowingly.\n"
            + "The dilemma is our everyday choices.\n"
            + "Even though you feel like a normal person your actions have consequences,\n"
            + "your mother, your fiance, your friends or even the people you cross on the streets.\n"
            + "All of them are affected in different magnitudes by your choices. \n \n "
            + "This game has different endings with every actions, it needs polishing and it's pretty short\n"
            + "We hope you play our game a few times to experience what could've happened, wish we had that feature in real life.\n"
            + "Hope you enjoyed the experience, now you will meet the team";
    }
}