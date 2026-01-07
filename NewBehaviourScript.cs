using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem;
using UnityEngine.UI;


public class scHUDMainBtn : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public Button btn;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    //==========마우스
    public void OnPointerEnter(PointerEventData eventData)
    {
        //감성 커서 over 
        Debug.Log("IN");


    }

    public void OnPointerExit(PointerEventData eventData)
    {
        //감성 커서 exit
        Debug.Log("OUT");


    }
}
