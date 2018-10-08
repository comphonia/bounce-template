using UnityEngine.EventSystems; 
using UnityEngine;

public class RightButton : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    static public bool isPressed = false;
    PlayerController pc;

    private void Start()
    {
        pc = PlayerController.instance;

    }

    public void OnPointerDown(PointerEventData eventData)
    {
        isPressed = true;
        pc.movingRight = true;
        pc.StartCoroutine(pc.MovingRight()); 
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        isPressed = false;
        pc.movingRight = false; 
    }

}
