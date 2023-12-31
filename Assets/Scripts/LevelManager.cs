using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    public void LoadMenu()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("Menu");
        Time.timeScale = 1;
    }

    public void LoadLevel()
    {
        SceneManager.LoadScene("Level");
        Time.timeScale = 1;
    }

    public void Exit()
    {
        Application.Quit();
    }

    public void PauseGame ()
        {
            Time.timeScale = 0;
        }
    public void ResumeGame ()
        {
            Time.timeScale = 1;
        }
}
