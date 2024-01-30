using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OpeningScript : MonoBehaviour
{
    public Image image;
    public Text text;

    public float eraseSpeed = 1;
    private Color newColor = new Color(255, 255, 255, 1);

    public float startTime = 5;

    void Start()
    {
        ControllerScript.playState = false;
    }

    void Update()
    {
        startTime -= 1 * Time.deltaTime;

        if (startTime <= 0)
        {
            newColor.a -= eraseSpeed * Time.deltaTime;

            image.color = newColor;
            text.color = newColor;
        }

        if (image.color.a <= 0 && text.color.a <= 0)
        {
            ControllerScript.playState = true;
            this.gameObject.SetActive(false);
        }

        if (Input.GetMouseButtonDown(0))
        {
            ControllerScript.playState = true;
            this.gameObject.SetActive(false);
        }
    }
}
