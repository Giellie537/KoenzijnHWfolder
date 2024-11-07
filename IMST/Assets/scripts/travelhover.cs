using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class travelhover : MonoBehaviour , IPointerExitHandler , IPointerClickHandler , IPointerEnterHandler
{

public GameObject HoverPanel;

public void OnPointerClick(PointerEventData eventData){
    HoverPanel.SetActive(true);
}

public void OnPointerExit(PointerEventData eventData){
    HoverPanel.SetActive(false);
}

public void OnPointerEnter(PointerEventData eventData){
    HoverPanel.SetActive(true);
}

}
