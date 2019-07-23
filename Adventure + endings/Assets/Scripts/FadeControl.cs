using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadeControl : MonoBehaviour
{
    public GameObject []img;

    void Start ()
    {
        for(int i=0;i<img.Length;i++)
        {
            img[i].SetActive(true);
        }       
    }
}