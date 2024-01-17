using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColourSquare : MonoBehaviour
{
    private Color _squareColor;
    public float changeSpeed;
    private float _hue, _saturation, _value;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        _squareColor = this.GetComponent<Image>().color;
        Color.RGBToHSV(_squareColor, out _hue, out _saturation, out _value);

        this.GetComponent<Image>().color = Color.HSVToRGB(_hue + changeSpeed * Time.deltaTime, _saturation, _value);
    }
}
