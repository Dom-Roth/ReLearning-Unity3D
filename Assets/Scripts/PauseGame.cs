using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseGame : MonoBehaviour
{
    public bool gamePaused = false;
    public GameObject pauseMenu;

    void Update()
    {
        if (Input.GetButtonDown("Cancel"))
        {
            if (gamePaused)
            {
                UnpauseGame();
            }
            else
            {
                Time.timeScale = 0; // This pauses the game!
                gamePaused = true;
                Cursor.visible = true;
                this.GetComponent<AudioSource>().Pause();
                pauseMenu.SetActive(true); 
            }
        }
    }

    public void UnpauseGame()
    {
        pauseMenu.SetActive(false);
        this.GetComponent<AudioSource>().UnPause();
        Cursor.visible = false;
        gamePaused = false;
        Time.timeScale = 1; // This resumes the game!
    }

    public void RestartLevel()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(1);
    }
    
    public void QuitLevel()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(2);
    }
}
