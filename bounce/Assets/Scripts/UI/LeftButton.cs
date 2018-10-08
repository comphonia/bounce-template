using UnityEngine.EventSystems;
using UnityEngine;

public class LeftButton : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
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
        pc.movingLeft = true;
        pc.StartCoroutine(pc.MovingLeft()); 
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        isPressed = false;
        pc.movingLeft = false; 
    }

}
