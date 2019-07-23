using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Creditos : MonoBehaviour
{
    public float posicionY;
    public float velocidadY;

	void Start ()
    {
        gameObject.transform.position = new Vector2 (0,posicionY);
        StartCoroutine(EndGame(22f));	
	}
	
	void Update ()
    {

        gameObject.transform.position += new Vector3 (0, velocidadY,0);		
	}

    IEnumerator EndGame(float time)
    {
        yield return new WaitForSeconds(time);
        SceneManager.LoadScene(0);
    }
}
