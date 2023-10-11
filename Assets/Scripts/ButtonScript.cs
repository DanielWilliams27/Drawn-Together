using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ButtonScript : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, ISelectHandler, IDeselectHandler
{
    public Text text;
    bool select = false;

    public void OnDeselect(BaseEventData eventData)
    {
        text.color = Color.black;
        select = false;
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        text.color = Color.white;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        if (select == false)
        {
            text.color = Color.black;
        }
    }

    public void OnSelect(BaseEventData eventData)
    {
        text.color = Color.white;
        select = true;
    }
}
