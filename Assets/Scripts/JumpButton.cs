using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class JumpButton : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{

    public void OnPointerDown(PointerEventData eventData)
    {
        if (PlayerJump.instance != null)
        {
            PlayerJump.instance.Set_CanSetPower(true);
        }
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        if (PlayerJump.instance != null)
        {
            PlayerJump.instance.Set_CanSetPower(false);
        }
    }
}
