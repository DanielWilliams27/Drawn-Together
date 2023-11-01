using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ReverseButtonScript : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler//, ISelectHandler, IDeselectHandler
{
    public Text text;

    public void OnEnable()
    {
        text.color = Color.white;
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        text.color = Color.black;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        text.color = Color.white;
    }

    public void OnSelect(BaseEventData eventData)
    {
        text.color = Color.black;
    }
}
