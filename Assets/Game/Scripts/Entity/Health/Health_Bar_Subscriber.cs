using UnityEngine;

public class Health_Bar_Subscriber : MonoBehaviour
{
    private HealthComponent healthComponent;

    private float originalScale;

    private void Awake()
    {
        healthComponent = GetComponentInParent<HealthComponent>();
    }

    private void OnEnable()
    {
        Initialize();
    }

    private void OnDisable()
    {
        healthComponent.OnChangeHp.RemoveAction(UpdateHealthBar);
        healthComponent.OnChangeMaxHp.RemoveAction(UpdateHealthBar);
    }

    public void Initialize()
    {
        originalScale = transform.localScale.x;
        healthComponent.OnChangeHp.AddAction(UpdateHealthBar);
        healthComponent.OnChangeMaxHp.AddAction(UpdateHealthBar);
        UpdateHealthBar();
    }

    public void UpdateHealthBar()
    {
        Vector3 tmpScale = transform.localScale;
        tmpScale.x = (healthComponent.Hp.Get * originalScale) / healthComponent.MaxHp.Get;
        transform.localScale = tmpScale;
    }
}
