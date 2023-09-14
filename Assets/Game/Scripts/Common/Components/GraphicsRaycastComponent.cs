using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections.Generic;

public class GraphicsRaycastComponent : MonoBehaviour
{
    private EventSystem eventSystem;

    private PointerEventData eventData;
    private List<RaycastResult> results = new List<RaycastResult>();

    private void Awake()
    {
        eventSystem = FindObjectOfType<EventSystem>();
        eventData = new PointerEventData(eventSystem);
    }

    public bool CheckOnClickOpenPanel(GameObject hit, GraphicRaycaster raycaster)
    {
        if (raycaster == null) return false;

        results.Clear();
        eventData.position = Input.mousePosition;
        raycaster.Raycast(eventData, results);

        //print(results.Count);
        foreach (RaycastResult result in results)
        {
            if (result.gameObject.GetComponent<Panel>() == null) continue;

            //print(result.gameObject.name);
            if (hit != result.gameObject) continue;

            //print("Панель, которая открыта");
            return true;
        }

        return false;
    }
}