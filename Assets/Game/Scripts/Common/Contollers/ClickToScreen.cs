using UnityEngine;
using UnityEngine.EventSystems;

public class ClickToScreen : MonoBehaviour
{
    private PanelSelected currentPanel;
    private SelectComponent selectComponent;

    private PhysicsRaycastComponent phisicsRaycastComponent;
    private GraphicsRaycastComponent UI_RaycastComponent;

    private static ClickToScreen Instance;

    private void Awake()
    {
        if (Instance == null)  Instance = this;
        else
            Destroy(this);

        selectComponent = new SelectComponent();

        currentPanel = FindObjectOfType<PanelSelected>();
        EventSystem eventSystem = FindObjectOfType<EventSystem>();
        
        UI_RaycastComponent = new GraphicsRaycastComponent(eventSystem);
        phisicsRaycastComponent = new PhysicsRaycastComponent(Camera.main);
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0) == false) return;

        if (UI_RaycastComponent.IsClickOpenPanel(currentPanel.Current, currentPanel.Raycaster)) return;

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
}
