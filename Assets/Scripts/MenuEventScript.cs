using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuEventScript : MonoBehaviour
{
    public GameObject main;
    public GameObject options;
    public GameObject levels;
    public GameObject guide;
    public GameObject credits;

    void Start()
    {
                
    }

    public void LoadScene(string scene)
    {
        SceneManager.LoadScene(scene);
    }

    public void LoadMain(GameObject deactivateMenu)
    {
        deactivateMenu.SetActive(false);
        main.SetActive(true);
    }

    public void LoadOptions(GameObject deactivateMenu)
    {
        deactivateMenu.SetActive(false);
        options.SetActive(true);
    }

    public void LoadLevels(GameObject deactivateMenu)
    {
        deactivateMenu.SetActive(false);
        levels.SetActive(true);
    }

    public void LoadGuide(GameObject deactivateMenu)
    {
        deactivateMenu.SetActive(false);
        guide.SetActive(true);
    }

    public void LoadCredits(GameObject deactivateMenu)
    {
        deactivateMenu.SetActive(false);
        credits.SetActive(true);
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
