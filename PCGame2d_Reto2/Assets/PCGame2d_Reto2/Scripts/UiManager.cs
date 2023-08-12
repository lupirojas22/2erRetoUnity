using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UiManager : MonoBehaviour
{
    public string sceneName = "CanvasPlayMenu";
    public int currentSceneIndex;

    private bool isPaused = false;


    public void TogglePause()
    {
        isPaused = !isPaused;

        if (isPaused)
        {
            Time.timeScale = 0f; // Pausar el tiempo del juego
        }
        else
        {
            Time.timeScale = 1f; // Reanudar el tiempo del juego
        }
    }

    public void ExitButtonPressed()
    {
        Debug.Log("Sali del juego");
        Application.Quit();
    }

    public void ChangeScene()
    {
        SceneManager.LoadScene(currentSceneIndex);
        Time.timeScale = 1f;
    }

    public GameObject[] objectsToReset;

    public void RestartLevel()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex);
        Time.timeScale = 1f;
    }




}
