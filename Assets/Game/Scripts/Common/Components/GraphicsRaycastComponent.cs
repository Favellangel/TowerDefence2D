using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class GraphicsRaycastComponent 
{
    private PointerEventData eventData;
    private List<RaycastResult> results = new();

    public GraphicsRaycastComponent(EventSystem eventSystem)
    {
        eventData = new PointerEventData(eventSystem);
    }

    public bool IsClickOpenPanel(GameObject target, GraphicRaycaster raycaster)
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
            if (target != result.gameObject) continue;

            //print("������, ������� �������");
            return true;
        }

        return false;
    }
}
