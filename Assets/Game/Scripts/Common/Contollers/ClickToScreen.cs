using UnityEngine;
using UnityEngine.EventSystems;

public class ClickToScreen : MonoBehaviour
{
    private void Awake()
    {
        if (Instance == null) 
            Instance = this;
        else
            Destroy(this);

        selectComponent = new SelectComponent();

        currentPanel = FindObjectOfType<PanelSelected>();
        EventSystem eventSystem = FindObjectOfType<EventSystem>();
        
        UI_RaycastComponent = new GraphicsRaycastComponent(eventSystem);
        phisicsRaycastComponent = new PhisicsRaycastComponent(transform.position);
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0) == false) return;

        if (UI_RaycastComponent.IsClickOpenPanel(currentPanel.GetPanel(), currentPanel.GetGraphicRaycaster())) return;

        phisicsRaycastComponent.IsClickToCollider();

        if(phisicsRaycastComponent.Hit)      
        {
            ISelecteble selecteble = phisicsRaycastComponent.Hit.collider.GetComponent<ISelecteble>();
            selectComponent.Select(selecteble);
        }
        else
        {
            selectComponent.Deselect();
        }
    }

    private PanelSelected currentPanel;
    private SelectComponent selectComponent;

    private PhisicsRaycastComponent phisicsRaycastComponent;
    private GraphicsRaycastComponent UI_RaycastComponent;

    private static ClickToScreen Instance;
}
