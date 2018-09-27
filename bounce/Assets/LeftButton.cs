using UnityEngine.EventSystems;
using UnityEngine;

public class LeftButton : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    static public bool isPressed = false;

    public void OnPointerDown(PointerEventData eventData)
    {
        isPressed = true;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        isPressed = false;
    }

}
