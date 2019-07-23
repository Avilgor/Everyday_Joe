using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoadScene : MonoBehaviour
{
    public int indice;
    public GameObject finalDisplay;
    Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    public void Carga()
    {
        try
        {
            if (DATOS.showing == false)
            {
                anim.SetTrigger("Fade");
                StartCoroutine(FadeOut(1f));
            }
            else
            {
               
            }
        }
        catch (Exception e)
        {
            Debug.Log(e);
        }   
    }

    public void CargaDormitorio()
    {
        try
        {
            if (DATOS.showing == false && DATOS.nota)
            {
                anim.SetTrigger("Fade");
                StartCoroutine(FadeOut(1f));
            }
            else
            {
                if (DATOS.nota == false)
                {
                    GameObject.FindGameObjectWithTag("PopUp").SetActive(true);
                    GameObject.FindGameObjectWithTag("PopUp").GetComponent<PopUps>().SetMsg("Maybe I'm forgotting something?");
                    DATOS.showing = true;
                }
                if (DATOS.vestido == false && DATOS.dia == 1 && DATOS.nota==true)
                {
                    GameObject.FindGameObjectWithTag("PopUp").SetActive(true);
                    GameObject.FindGameObjectWithTag("PopUp").GetComponent<PopUps>().SetMsg("I should put my clothes on first.");
                    DATOS.showing = true;
                }
                if (DATOS.vestido == false && DATOS.dia == 2 && DATOS.nota == true)
                {
                    GameObject.FindGameObjectWithTag("PopUp").SetActive(true);
                    GameObject.FindGameObjectWithTag("PopUp").GetComponent<PopUps>().SetMsg("I thought we had this sorted. Outside the room dressed, inside as you wish.");
                    DATOS.showing = true;
                }
                if (DATOS.vestido == false && DATOS.dia == 3 && DATOS.nota == true)
                {
                    GameObject.FindGameObjectWithTag("PopUp").SetActive(true);
                    GameObject.FindGameObjectWithTag("PopUp").GetComponent<PopUps>().SetMsg("I know, it’s so comfy going freely with only an underwear, but social norms are social norms pal.");
                    DATOS.showing = true;
                }
            }
        }
        catch (Exception e)
        {
            Debug.Log(e);
        }
    }

    public void CargaCasa()
    {
        try
        {
            if (DATOS.dia == 3 && DATOS.musicaComp == true && DATOS.compra == true)
            {
                finalDisplay.SetActive(true);
                StartCoroutine(LastScene(2f));
            }
            else
            {
                anim.SetTrigger("Fade");
                StartCoroutine(FadeOut(1f));
            }
        }
        catch (Exception e)
        {
            Debug.Log(e);
        }
    }

    IEnumerator FadeOut(float time)
    {
        yield return new WaitForSeconds(time);       
        SceneManager.LoadScene(indice);           
    }

    IEnumerator LastScene(float time)
    {
        yield return new WaitForSeconds(time);
        SceneManager.LoadScene(15);
    }
}