using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class GraphicsRaycastComponent 
{
    private PointerEventData eventData;
    private List<RaycastResult> results = new List<RaycastResult>();

    public GraphicsRaycastComponent(EventSystem eventSystem)
    {
        eventData = new PointerEventData(eventSystem);
    }

    public bool IsClickOpenPanel(GameObject hit, GraphicRaycaster raycaster)
    {
        if (raycaster == null) return false;

        results.Clear();
        eventData.position = Input.mousePosition;
        raycaster.Raycast(eventData, results);

        //print(results.Count);
        foreach (RaycastResult result in results)
        {
            if (result.gameObject.GetComponent<Panelmoving>() == null) continue;

            //print(result.gameObject.name);
            if (hit != result.gameObject) continue;

            //print("Панель, которая открыта");
            return true;
        }

        return false;
    }
}
