using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Telefono : MonoBehaviour
{
    public Text texto;

    public void Llamada()
    {

        switch (DATOS.dia)
        {
            case 1:
                texto.text = "She talked me about so many cousins that I didn’t know I had, everyday you learn something new." +
                                    "She seemed happy about the call, feels good."; break;
            case 2:
                if (DATOS.llamadas == 1)
                {
                    texto.text = "It was lovely. She talked to me about a friend of hers that made a band a lot of years back." +
                                  "The band was called The Good Ol’ Youngins. She sounded pretty nostalgic, I wonder if their CDs will be at the mall.";
                    DATOS.llamadas++;
                }
                else
                {
                    texto.text = "She talked me about so many cousins that I didn’t know I had, everyday you learn something new." +
                                    "She seemed happy about the call, feels good."; 
                }
                break;

            case 3:
                if (DATOS.llamadas == 1)
                {
                    texto.text = "It was lovely. She talked to me about a friend of hers that made a band a lot of years back." +
                                  "The band was called The Good Ol’ Youngins.She sounded pretty nostalgic, I wonder if their CDs will be at the mall.";
                    DATOS.llamadas++;
                }
                else
                {
                    if (DATOS.llamadas == 2)
                    {
                        texto.text = "Mom- Son, I’m really grateful for your calls. Since your father passed away I’ve felt alone but your calls make my days happier, I couldn’t have a better son." +
                             "…" +
                             "I wasn’t expecting that.I’m glad I can help my mother now after all that she has done for me.";
                    }
                    else
                    {
                        texto.text = "She talked me about so many cousins that I didn’t know I had, everyday you learn something new." +
                                     "She seemed happy about the call, feels good.";
                    }


                }
                break;
        }

        if (DATOS.llama == false)
        {
            DATOS.llama = true;
            DATOS.llamadas++;
        }
       
    }	
}