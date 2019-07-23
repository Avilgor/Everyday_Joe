using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class DoorEffects : MonoBehaviour
{
    public Text texto;
    public GameObject glow;

    private void Start()
    {
        texto.color = Color.clear;
    }

    public void FadeIn()
    {
        texto.color = Color.Lerp(texto.color, Color.white, 1);
    }

    public void FadeOut()
    {
        texto.color = Color.Lerp(texto.color, Color.clear, 1);
    }

    public void GlowIn()
    {
        glow.SetActive(true);
    }

    public void GlowOut()
    {
        glow.SetActive(false);
    }
}