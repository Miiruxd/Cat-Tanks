using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class SwapCatsButton : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public bool mouseOverSwapButton = false;

    public void OnPointerEnter(PointerEventData pointerEventData)
    {
        mouseOverSwapButton = true;
    }

    public void OnPointerExit(PointerEventData pointerEventData)
    {
        mouseOverSwapButton = false;
    }
}
