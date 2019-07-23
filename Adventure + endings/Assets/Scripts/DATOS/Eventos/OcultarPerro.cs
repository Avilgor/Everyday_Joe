using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OcultarPerro : MonoBehaviour
{
    void Start()
    {
        if (DATOS.perroDone == true || DATOS.dia !=1)
        {
            this.gameObject.SetActive(false);
        }
    }

    void Update ()
    {
        if (DATOS.perroDone == true)
        {
            this.gameObject.SetActive(false);
        }
    }
}