using UnityEngine;

public class BtnChangePanel : BtnSubscriber
{
    [SerializeField] private GameObject nextPanel;
    private GameObject currentPanel;

    protected override void Awake()
    {
        base.Awake();
        currentPanel = GetComponentInParent<Canvas>().gameObject;
    }

    protected override void Execute()
    {
        nextPanel.SetActive(true);
        currentPanel.SetActive(false);
    }
}
