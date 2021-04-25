using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Random = UnityEngine.Random;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    public int loadLevel;
    
    public GameObject hintBox;
    public int hintNum;
    private String[] hintTexts = {
        "Collect 5 Coins!",
        "Don't Die!",
        "Don't let the timer hit 0!"
    };

    private void Start()
    {
        hintNum = Random.Range(0, 3);
        hintBox.GetComponent<Text>().text = hintTexts[hintNum];
    }

    public void StartGame()
    {
        GlobalLevel.levelNumber = 3;
        SceneManager.LoadScene(GlobalLevel.levelNumber);
    }

    public void LoadGame()
    {
        loadLevel = PlayerPrefs.GetInt("LoadLevelNum");
        if (loadLevel < 3)
        {
            SceneManager.LoadScene(GlobalLevel.levelNumber);
        }
        else
        {
            GlobalLevel.levelNumber = loadLevel;
            SceneManager.LoadScene(loadLevel);
        }
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
