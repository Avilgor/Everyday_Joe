using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teatro : MonoBehaviour
{
    public GameObject display;

    void Start()
    {
        if (DATOS.teatroDone == false && DATOS.dia == 3)
        {
            this.gameObject.SetActive(true);
        }
        else { gameObject.SetActive(false); }
    }

    public void comprar()
    {
        GameObject.FindGameObjectWithTag("PopUp").SetActive(true);
        GameObject.FindGameObjectWithTag("PopUp").GetComponent<PopUps>().SetMsg("Yes, RR&J sounds exciting and she has always loved theater. It will be a lovely date.");
        DATOS.teatro = true;
        DATOS.teatroDone = true;
        display.SetActive(false);
        this.gameObject.SetActive(false);
        DATOS.showing = false;
    }

    public void irse()
    {
        GameObject.FindGameObjectWithTag("PopUp").SetActive(true);
        GameObject.FindGameObjectWithTag("PopUp").GetComponent<PopUps>().SetMsg("I’ll pass, it probably would be boring, and going to the movies is so much better anyways.");
        display.SetActive(false);
        DATOS.teatroDone = true;
        this.gameObject.SetActive(false);
        DATOS.showing = false;
    }
}
