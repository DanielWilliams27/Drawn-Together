using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelEventScene : MonoBehaviour
{
    string currentSceneName;

    private void Start()
    {
        currentSceneName = SceneManager.GetActiveScene().name;
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
}
