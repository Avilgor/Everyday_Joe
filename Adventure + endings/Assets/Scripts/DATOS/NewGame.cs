using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEditor;
using System;
using UnityEngine.SceneManagement;

public class NewGame : MonoBehaviour
{
    public GameObject img;
    public void Nuevo()
    {
        try
        {
            if (File.Exists(DATOS.path))
            {
                File.Delete(DATOS.path);
                File.Create(DATOS.path);
                
            }
            NextLevel();
        }
        catch (Exception e)
        {
            Debug.Log(e);
        }
    }

    private void NextLevel()
    {        
        DATOS.dia = 1;
        img.SetActive(true);
        StartCoroutine(LoadScreen(3f));
    }

    IEnumerator LoadScreen(float time)
    {
        yield return new WaitForSeconds(time);
        SceneManager.LoadScene("Dormitorio");
        GameObject.Find("PopUp").SetActive(true);
        GameObject.Find("PopUp").GetComponent<PopUps>().SetMsg("Espace - Leave Object." +
            "\nEscape - Pause game" +
            "\nMouse - Selection");
        DATOS.showing = true;
    }
}