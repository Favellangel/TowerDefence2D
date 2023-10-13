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

    protected virtual void OnEnable()
    {
        onChange.AddAction(UpdateTxt);
        UpdateTxt();
    }

    protected virtual void OnDisable()
    {
        onChange.RemoveAction(UpdateTxt);
    }

    protected virtual void OnDestroy()
    {
        onChange.RemoveAction(UpdateTxt);
    }

    public void UpdateTxt()
    {
        txtComponent.text = currentTxt.GetString();
    }
}
