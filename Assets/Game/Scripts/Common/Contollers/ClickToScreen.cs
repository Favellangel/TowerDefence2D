using UnityEngine;

public class ClickToScreen : MonoBehaviour
{
    private Camera _camera;

    private Ray ray;
    private RaycastHit2D hit;

    private PanelMomentor panelMomentor;
    private SelectComponent selectComponent;
    private GraphicsRaycastComponent graphicsRaycastComponent;
    private static ClickToScreen Instance;

    private void Awake()
    {
        if (Instance == null) 
            Instance = this;
        else
            Destroy(this);

        _camera = Camera.main;
        selectComponent = new SelectComponent();

        panelMomentor = FindObjectOfType<PanelMomentor>();
        graphicsRaycastComponent = FindObjectOfType<GraphicsRaycastComponent>();
    }

    private void Start()
    {
        ray.origin = transform.position;
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0) == false) return;

        if (graphicsRaycastComponent.CheckOnClickOpenPanel(panelMomentor.GetPanel(), panelMomentor.GetGraphicRaycaster())) return;
        
        CheckOnClickToCollider();

        if (hit)
        {
            ISelecteble selecteble = hit.collider.GetComponent<ISelecteble>();
            selectComponent.Select(selecteble);
        }
        else
        {
            selectComponent.Deselect();
        }
    }

    private void CheckOnClickToCollider()
    {
        ray = _camera.ScreenPointToRay(Input.mousePosition);
        hit = Physics2D.Raycast(ray.origin, ray.direction, 100);
    }
}
