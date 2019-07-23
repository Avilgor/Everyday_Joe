using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SimpleLoadScene : MonoBehaviour
{
    public int indice;
    public void Credits()
    {
        SceneManager.LoadScene(indice);
    }
}
