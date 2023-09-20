using UnityEngine;
using UnityEngine.UI;

public class PanelSelected : MonoBehaviour
{
    private GameObject current;
    private GraphicRaycaster raycaster;

    public GameObject GetPanel()
    {
        return current;
    }

    public GraphicRaycaster GetGraphicRaycaster()
    {
        return raycaster;
    }

    public void Set(GameObject panel)
    { 
        current = panel;

        if (current == null) 
            raycaster = null;
        else
            raycaster = current.transform.GetComponentInParent<GraphicRaycaster>();
    }   
}
