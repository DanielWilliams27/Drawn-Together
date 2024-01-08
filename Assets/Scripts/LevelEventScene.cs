using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelEventScene : MonoBehaviour
{
    string currentSceneName;
    public GameObject pauseMenu, opening;

    private void Start()
    {
        currentSceneName = SceneManager.GetActiveScene().name;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && !opening.activeInHierarchy)
        {
            if (ControllerScript.playState)
            {
                pauseMenu.SetActive(true);
                ControllerScript.playState = false;
            }
            else
            {
                ControllerScript.playState = true;
                pauseMenu.SetActive(false);
            }
        }
    }

    public void ReloadScene()
    {
        SceneManager.LoadScene(currentSceneName);
        ControllerScript.playState = true;
    }

    public void LoadScene(string scene)
    {
        SceneManager.LoadScene(scene);
    }

    public void Continue()
    {
        ControllerScript.playState = true;
        pauseMenu.SetActive(false);
    }
}
