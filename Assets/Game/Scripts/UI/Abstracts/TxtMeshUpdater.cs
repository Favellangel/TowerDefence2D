using TMPro;
using UnityEngine;

public abstract class TxtMeshUpdater: MonoBehaviour
{
    private TextMeshProUGUI txtComponent;

    protected IEventable onChange;
    protected IStringable currentTxt;


    protected virtual void Awake()
    {
        txtComponent = GetComponent<TextMeshProUGUI>();
    }

    private void OnEnable()
    {
        onChange.AddAction(UpdateTxt);
        UpdateTxt();
    }

    private void OnDisable()
    {
        onChange.RemoveAction(UpdateTxt);
    }

    private void OnDestroy()
    {
        onChange.RemoveAction(UpdateTxt);
    }

    public void UpdateTxt()
    {
        txtComponent.text = currentTxt.GetString();
    }
}
