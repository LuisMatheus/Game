﻿using UnityEngine;
using UnityEngine.EventSystems;

public class DropZone : MonoBehaviour, IDropHandler
{
    public void OnDrop(PointerEventData eventData)
    {
        Debug.Log("On Drop to " + gameObject.name);

        Draggable d = eventData.pointerDrag.GetComponent<Draggable>();
        if(d != null)
        {
            Debug.Log("DROPED");
            Destroy(d.transform.gameObject);
            
        }
    }

}
