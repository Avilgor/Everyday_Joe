using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    private bool paused=false;
    [SerializeField]
    public GameObject pauseMenu;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (paused)
            {
                ResumeGame();
            }
            else
            {
                paused = true;
                pauseMenu.SetActive(true);
                Time.timeScale = 0f;
            }
        }
    }

    public void ResumeGame()
    {
        //DATOS.showing = true;
        paused = false;
        pauseMenu.SetActive(false);
        Time.timeScale = 1f;
    }

    public void Exit()
    {       
        Time.timeScale = 1f;
        SaveGame.Guarda(SceneManager.GetActiveScene().buildIndex);
        SceneManager.LoadScene(0);
        DATOS.showing = false;
    }
}
