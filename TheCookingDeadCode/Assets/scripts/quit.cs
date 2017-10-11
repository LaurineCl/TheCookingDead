using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class quit : MonoBehaviour, IPointerClickHandler
{

    public void OnPointerClick(PointerEventData eventData)
    {
        Debug.Log("quitter ok");
        if (eventData.button == PointerEventData.InputButton.Left)
        {
            Application.Quit();
            Debug.Log("onclickquit");
        }
    }
}
