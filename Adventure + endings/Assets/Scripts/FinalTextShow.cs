using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinalTextShow : MonoBehaviour
{
    public GameObject next;

    private void Start()
    {
        StartCoroutine(FadeOut(3f));
    }

    public void Siguiente()
    {
        try
        {
            gameObject.SetActive(false);
            next.SetActive(true);            
        }
        catch (Exception e)
        { }
    }

    IEnumerator FadeOut(float time)
    {
        yield return new WaitForSeconds(time);
        gameObject.GetComponent<Animator>().SetTrigger("Fade");
    }
}
