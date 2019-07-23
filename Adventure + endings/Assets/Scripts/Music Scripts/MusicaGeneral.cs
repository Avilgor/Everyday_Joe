using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MusicaGeneral : MonoBehaviour
{
    AudioSource sonidos;
    bool casa;
    bool menu;
    bool eexteriores;
    bool eending;
    bool creditos;
    float time = 0.1f;
    // Use this for initalization
    public AudioSource sound;
    public AudioClip beat3;
    public AudioClip percusiondefondo;
    public AudioClip exteriores;
    public AudioClip ending;
    public AudioClip chill;


    void OnEnable()
    {
        //Tell our 'OnLevelFinishedLoading' function to start listening for a scene change as soon as this script is enabled.
        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    void OnDisable()
    {
        //Tell our 'OnLevelFinishedLoading' function to stop listening for a scene change as soon as this script is disabled. Remember to always have an unsubscription for every delegate you subscribe to!
        SceneManager.sceneLoaded -= OnSceneLoaded;
    }
    void Start()
    {
        DontDestroyOnLoad(this.gameObject);
        sound.Stop();

    }
    void Update()
    {
        GameObject[] musicas = GameObject.FindGameObjectsWithTag("music");

        if (musicas.Length > 1)
        {
            Destroy(this.gameObject);
        }
        if (menu == true && sound.clip != beat3)
        {
            print("beat3");
            sound.clip = beat3;
            StartCoroutine(musicalymenu(time));
        }

        if (casa == true && sound.clip != percusiondefondo)
        {
            print("percusióndefondo");
            sound.clip = percusiondefondo;
            StartCoroutine(musicalycasa(time));
        }

        if (creditos == true && sound.clip != chill)
        {
            print("chill");
            sound.clip = chill;
            StartCoroutine(musicalymenu(time));
        }

        if (eexteriores == true && sound.clip != exteriores)
        {
            print("exteriores");
            sound.clip = exteriores;
            StartCoroutine(musicalymenu(0.1f));
        }

        if (eending == true && sound.clip != ending)
        {
            print("ending");
            sound.clip = ending;
            StartCoroutine(musicalymenu(time));
        }

    }

    void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        if ((scene.buildIndex == 0))
        {
            print("menu");
            print(scene.buildIndex);
            menu = true;
            casa = false;
            eexteriores = false;
            eending = false;
            creditos = false;

        }

        if ((scene.buildIndex == 1))
        {
            print("créditos");
            print(scene.buildIndex);
            menu = false;
            casa = false;
            eexteriores = false;
            eending = false;
            creditos = true;


        }

        if ((scene.buildIndex < 8) && (scene.buildIndex > 1) || (scene.buildIndex == 13))
        {
            print("casa");
            print(scene.buildIndex);
            menu = false;
            casa = true;
            eexteriores = false;
            eending = false;
            creditos = false;
        }

        if ((scene.buildIndex >= 8) && (scene.buildIndex < 14) && (scene.buildIndex != 13) && (DATOS.dia < 2))
        {
            print("exteriores" + DATOS.dia);
            print(scene.buildIndex);
            menu = false;
            casa = false;
            eexteriores = true;
            eending = false;
            creditos = false;
        }

        if ((scene.buildIndex >= 8) && (scene.buildIndex < 14) && (scene.buildIndex != 13) && (DATOS.dia > 1))
        {
            print("exteriores/chill" + DATOS.dia);
            print(scene.buildIndex);
            menu = false;
            casa = false;
            eexteriores = false;
            eending = false;
            creditos = true;
        }


        if ((scene.buildIndex == 15))
        {
            print("ending");
            print(scene.buildIndex);
            menu = false;
            casa = false;
            eexteriores = false;
            eending = true;
            creditos = false;
        }


    }
    IEnumerator musicalymenu(float time)
    {
        yield return new WaitForSeconds(time);
        if (!sound.isPlaying)
        {
            print("sound play");
            sound.volume = 1f;
            sound.Play();
        }

    }

    IEnumerator musicalycasa(float time)
    {
        yield return new WaitForSeconds(time);

        if (!sound.isPlaying)
        {
            print("sound play");
            sound.volume = 0.2f;
            sound.Play();
        }

    }
}
