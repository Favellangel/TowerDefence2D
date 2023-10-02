using UnityEngine;

public class Health_Bar_Updater : MonoBehaviour
{
    private HealthComponent healthComponent;

    private float originalScale;

    private void Awake()
    {
        healthComponent = GetComponentInParent<HealthComponent>();
    }

    private void OnEnable()
    {
        originalScale = transform.localScale.x;
        healthComponent.onChangeHp.AddAction(UpdateHealthBar);
        healthComponent.onChangeMaxHp.AddAction(UpdateHealthBar);
        UpdateHealthBar();
    }

    private void OnDisable()
    {
        healthComponent.onChangeHp.RemoveAction(UpdateHealthBar);
        healthComponent.onChangeMaxHp.RemoveAction(UpdateHealthBar);
    }

    private void OnDestroy()
    {
        healthComponent.onChangeHp.RemoveAction(UpdateHealthBar);
        healthComponent.onChangeMaxHp.RemoveAction(UpdateHealthBar);
    }

    public void UpdateHealthBar()
    {
        Vector3 tmpScale = transform.localScale;
        tmpScale.x = (healthComponent.Hp.Get * originalScale) / healthComponent.MaxHp.Get;
        transform.localScale = tmpScale;
    }
}
