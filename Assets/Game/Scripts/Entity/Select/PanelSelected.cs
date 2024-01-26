using UnityEngine;
using UnityEngine.UI;

public class PanelSelected : MonoBehaviour
{
    public GameObject Current { get; private set; }
    public GraphicRaycaster Raycaster { get; private set; }

    public void Set(GameObject panel)
    {
        Current = panel;

        if (Current == null) 
            Raycaster = null;
        else
            Raycaster = Current.transform.GetComponentInParent<GraphicRaycaster>();
    }   
}
