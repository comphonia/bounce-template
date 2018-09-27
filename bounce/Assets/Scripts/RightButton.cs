using UnityEngine.EventSystems; 
using UnityEngine;

public class RightButton : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
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
