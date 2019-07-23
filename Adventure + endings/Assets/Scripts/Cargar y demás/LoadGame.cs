using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.IO;
using System;


public class LoadGame : MonoBehaviour
{
    public GameObject img;

    public void Load()
    {
        int dia, room;
        try
        {
            if (File.Exists(DATOS.path))
            {
                StreamReader reader = new StreamReader(DATOS.path);
                String[] situacion = new string[2];
                String txt="";

                txt = LeeLinea(reader);
                situacion = txt.Split('/');
                dia = Int32.Parse(situacion[0]);
                room = Int32.Parse(situacion[1]);
                DATOS.dia = dia;

                txt = LeeLinea(reader);
                if (txt.Equals(true)) { DATOS.nota = true; } else { DATOS.nota = false; }
                txt = LeeLinea(reader);
                if (txt.Equals(true)) { DATOS.wakeUp = true; } else { DATOS.wakeUp = false; }
                txt = LeeLinea(reader);
                if (txt.Equals(true)) { DATOS.vestido = true; } else { DATOS.vestido = false; }
                txt = LeeLinea(reader);
                if (txt.Equals(true)) { DATOS.martillo = true; } else { DATOS.martillo = false; }
                txt = LeeLinea(reader);
                if (txt.Equals(true)) { DATOS.sotano = true; } else { DATOS.sotano = false; }
                txt = LeeLinea(reader);
                if (txt.Equals(true)) { DATOS.llama = true; } else { DATOS.llama = false; }

                txt = LeeLinea(reader);
                DATOS.llamadas = Int32.Parse(txt);

                txt = LeeLinea(reader);
                if (txt.Equals(true)) { DATOS.cerdito = true; } else { DATOS.cerdito = false; }
                txt = LeeLinea(reader);
                if (txt.Equals(true)) { DATOS.perro = true; } else { DATOS.perro = false; }
                txt = LeeLinea(reader);
                if (txt.Equals(true)) { DATOS.perroDone = true; } else { DATOS.perroDone = false; }
                txt = LeeLinea(reader);
                if (txt.Equals(true)) { DATOS.compra = true; } else { DATOS.compra = false; }
                txt = LeeLinea(reader);
                if (txt.Equals(true)) { DATOS.revista = true; } else { DATOS.revista = false; }
                txt = LeeLinea(reader);
                if (txt.Equals(true)) { DATOS.cocinarDone = true; } else { DATOS.cocinarDone = false; }
                txt = LeeLinea(reader);
                if (txt.Equals(true)) { DATOS.comida = true; } else { DATOS.comida = false; }
                txt = LeeLinea(reader);
                if (txt.Equals(true)) { DATOS.super = true; } else { DATOS.super = false; }

                txt = LeeLinea(reader);
                DATOS.cantCompra = Int32.Parse(txt);

                txt = LeeLinea(reader);
                if (txt.Equals(true)) { DATOS.huevos = true; } else { DATOS.huevos = false; }
                txt = LeeLinea(reader);
                if (txt.Equals(true)) { DATOS.leche = true; } else { DATOS.leche = false; }
                txt = LeeLinea(reader);
                if (txt.Equals(true)) { DATOS.verdura = true; } else { DATOS.verdura = false; }
                txt = LeeLinea(reader);
                if (txt.Equals(true)) { DATOS.vagabundo = true; } else { DATOS.vagabundo = false; }


                txt = LeeLinea(reader);
                DATOS.vagbundoDecision = Int32.Parse(txt);

                txt = LeeLinea(reader);
                if (txt.Equals(true)) { DATOS.farmacia = true; } else { DATOS.farmacia = false; }
                txt = LeeLinea(reader);
                if (txt.Equals(true)) { DATOS.medicina = true; } else { DATOS.medicina = false; }
                txt = LeeLinea(reader);
                if (txt.Equals(true)) { DATOS.eventoFarmacia = true; } else { DATOS.eventoFarmacia = false; }
                txt = LeeLinea(reader);
                if (txt.Equals(true)) { DATOS.hombreMed = true; } else { DATOS.hombreMed = false; }
                txt = LeeLinea(reader);
                if (txt.Equals(true)) { DATOS.farmaceutico = true; } else { DATOS.farmaceutico = false; }
                txt = LeeLinea(reader);
                if (txt.Equals(true)) { DATOS.darDinero = true; } else { DATOS.darDinero = false; }
                txt = LeeLinea(reader);
                if (txt.Equals(true)) { DATOS.musicaComp = true; } else { DATOS.musicaComp = false; }
                txt = LeeLinea(reader);
                if (txt.Equals(true)) { DATOS.orfanato = true; } else { DATOS.orfanato = false; }
                txt = LeeLinea(reader);
                if (txt.Equals(true)) { DATOS.orfPolicia = true; } else { DATOS.orfPolicia = false; }
                txt = LeeLinea(reader);
                if (txt.Equals(true)) { DATOS.orfAyudar = true; } else { DATOS.orfAyudar = false; }
                txt = LeeLinea(reader);
                if (txt.Equals(true)) { DATOS.teatro = true; } else { DATOS.teatro = false; }
                txt = LeeLinea(reader);
                if (txt.Equals(true)) { DATOS.teatroDone = true; } else { DATOS.teatroDone = false; }

                Continua(room);
                reader.Close();
            }
            else
            {
                ShowMessage();
            }         
        } catch (Exception e)
        {
            ShowMessage();
            Debug.Log(e);
        }
    }

    private String LeeLinea(StreamReader read)
    {
        String leido = "";
        try
        {
            leido = read.ReadLine();
        }
        catch (Exception e)
        {
            Debug.Log(e);
        }
        return leido;
    }

    private void Continua(int indice)
    {      
        img.SetActive(true);
        StartCoroutine(LoadScreen(3f,indice));
        Debug.Log("Game loaded!");
    }

    private void ShowMessage()
    {
        GameObject.FindGameObjectWithTag("PopUp").SetActive(true);
        GameObject.FindGameObjectWithTag("PopUp").GetComponent<PopUps>().SetMsg("No saved game found.");
        DATOS.showing = true;       
    }

    IEnumerator LoadScreen(float time,int indice)
    {
        yield return new WaitForSeconds(time);
        SceneManager.LoadScene(indice);
    }
}