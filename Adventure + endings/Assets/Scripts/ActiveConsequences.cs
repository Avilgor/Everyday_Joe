using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActiveConsequences : MonoBehaviour
{
    public GameObject next;

    public void Siguiente()
    {
        try
        {
            next.SetActive(true);
        }
        catch (Exception e)
        { }       
    }
}