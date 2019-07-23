using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinalSceneChanger : MonoBehaviour
{
    private void Start()
    {
        StartCoroutine(FadeOut(3f));
    }

    public void cargaFinal()
    {
        SceneManager.LoadScene(16);
    }

    IEnumerator FadeOut(float time)
    {
        yield return new WaitForSeconds(time);
        gameObject.GetComponent<Animator>().SetTrigger("Fade");      
    }
}