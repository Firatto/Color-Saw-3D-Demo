using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

    public bool continuing;
    public bool gameOver;
    public GameObject gameOverUI;
    // Start is called before the first frame update
    void Start()
    {
        continuing = true;
        gameOver = false;
        gameOverUI.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Debug.isDebugBuild)
        {
            DebugKeys();
        }
    }

    private void DebugKeys()
    {
        if (Input.GetKeyDown(KeyCode.N))
        {
            GameManager nextLevel = gameObject.GetComponent<GameManager>();
            nextLevel.LoadNextScene();
        }
            
    }

    public void LoadNextScene()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex + 1);

    }
    public void GameOver()
    {
        gameOver = true;
        gameOverUI.SetActive(true);
        Time.timeScale = 0;
    }
    public void QuitGame()
    {
        Application.Quit();
    }

}
