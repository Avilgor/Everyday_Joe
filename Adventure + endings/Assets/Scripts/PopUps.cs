using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PopUps : MonoBehaviour
{
    public Text msg;
    public GameObject img;

	void Start ()
    {
        DontDestroyOnLoad(gameObject);
	}

    public void SetMsg(string msg)
    {
        img.SetActive(true);
        this.msg.text = msg;
    }

    public void cerrar()
    {
        img.SetActive(false);
        DATOS.showing = false;
    }
}
