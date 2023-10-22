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
    public Text upText, downText, leftText, rightText;

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
        upText.text = GlobalScript.up.ToString();
        downText.text = GlobalScript.down.ToString();
        leftText.text = GlobalScript.left.ToString();
        rightText.text = GlobalScript.right.ToString();
    }
}
