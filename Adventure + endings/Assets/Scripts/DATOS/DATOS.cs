using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public static class DATOS
{
    public static string path = Application.dataPath + "/StreamingAssets/Save.txt";
    public static bool showing = false;
    public static int dia=1;
    public static int[] decisiones = new int[10];
    public static int ArrayPointer = 0;


    public static bool nota = false;
    public static bool wakeUp = false;
    public static bool vestido = false;
    public static bool martillo = false;
    public static bool sotano = false;
    public static bool llama = false;
    public static int llamadas = 0;
    public static bool cerdito = false;
    public static bool perro = false;
    public static bool perroDone = false;
    public static bool compra = false;
    public static bool revista = false;
    public static bool cocinarDone = false;
    public static bool comida = false;
    public static bool super = false;
    public static int cantCompra = 0;
    public static bool huevos = false;
    public static bool leche = false;
    public static bool verdura = false;
    public static bool vagabundo = false;
    public static int vagbundoDecision = 0;//1-cuenta,2-se va,3-revista
    public static bool farmacia = false;
    public static bool medicina = false;
    public static bool eventoFarmacia = false;
    public static bool hombreMed = false;
    public static bool farmaceutico = false;
    public static bool darDinero = false;
    public static bool musicaComp = false;
    public static bool orfanato = false;
    public static bool orfPolicia = false;
    public static bool orfAyudar = false;
    public static bool teatro = false;
    public static bool teatroDone = false;
}