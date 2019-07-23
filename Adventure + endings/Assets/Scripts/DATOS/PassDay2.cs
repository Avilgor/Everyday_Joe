using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PassDay2 : MonoBehaviour
{
    public GameObject display;

    void Start()
    {
        if (DATOS.cocinarDone == true)
        {
            gameObject.SetActive(true);
        }
        else{ gameObject.SetActive(false); }
	}


    public void pasarDia()
    {
        DATOS.dia++;
        DATOS.nota = false;
        DATOS.wakeUp = false;
        DATOS.vestido = false;
        DATOS.llama = false;
        DATOS.compra = false;
        DATOS.cantCompra = 0;
        DATOS.cocinarDone = false;
        DATOS.huevos = false;
        DATOS.verdura = false;
        DATOS.medicina = false;
        DATOS.leche = false;
        display.SetActive(false);
        DATOS.showing = false;
        SceneManager.LoadScene("Dormitorio");
    }

    public void esperar()
    {
        display.SetActive(false);
        DATOS.showing = false;
    }
}
