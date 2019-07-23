using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEditor;
using System;


public static class SaveGame
{
    public static void Guarda(int roomIndex)
    {
        try
        {
            StreamWriter sw = new StreamWriter(DATOS.path);

            if (!File.Exists(DATOS.path))
            {
                File.Create(DATOS.path);
                //sw.WriteLine("");
            }

            sw.WriteLine(DATOS.dia+"/"+roomIndex);
            sw.WriteLine(DATOS.nota);
            sw.WriteLine(DATOS.wakeUp);
            sw.WriteLine(DATOS.vestido);
            sw.WriteLine(DATOS.martillo);
            sw.WriteLine(DATOS.sotano);
            sw.WriteLine(DATOS.llama);
            sw.WriteLine(DATOS.llamadas); //int
            sw.WriteLine(DATOS.cerdito);
            sw.WriteLine(DATOS.perro);
            sw.WriteLine(DATOS.perroDone);
            sw.WriteLine(DATOS.compra);
            sw.WriteLine(DATOS.revista);
            sw.WriteLine(DATOS.cocinarDone);
            sw.WriteLine(DATOS.comida);
            sw.WriteLine(DATOS.super);
            sw.WriteLine(DATOS.cantCompra); //int
            sw.WriteLine(DATOS.huevos);
            sw.WriteLine(DATOS.leche);
            sw.WriteLine(DATOS.verdura);
            sw.WriteLine(DATOS.vagabundo);
            sw.WriteLine(DATOS.vagbundoDecision); //int
            sw.WriteLine(DATOS.farmacia);
            sw.WriteLine(DATOS.medicina);
            sw.WriteLine(DATOS.eventoFarmacia);
            sw.WriteLine(DATOS.hombreMed);
            sw.WriteLine(DATOS.farmaceutico);
            sw.WriteLine(DATOS.darDinero);
            sw.WriteLine(DATOS.musicaComp);
            sw.WriteLine(DATOS.orfanato);
            sw.WriteLine(DATOS.orfPolicia);
            sw.WriteLine(DATOS.orfAyudar);
            sw.WriteLine(DATOS.teatro);
            sw.WriteLine(DATOS.teatroDone);

            sw.Close();

            Debug.Log("Game saved.");
        }
        catch (Exception e)
        {
            Debug.Log(e);
        }
    }
}