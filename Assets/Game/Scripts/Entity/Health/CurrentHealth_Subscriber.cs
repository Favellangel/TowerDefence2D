using TMPro;
using UnityEngine;

public class CurrentHealth_Subscriber : MonoBehaviour
{
    private TextMeshProUGUI text;
    private HealthComponent healthComponent;

    private void Awake()
    {
        GoldComponent goldComponent = FindObjectOfType<GoldComponent>(true);

        healthComponent = goldComponent.GetComponent<HealthComponent>();
        text = GetComponent<TextMeshProUGUI>();
    }

    private void OnEnable()
    {
        Initialize();
    }

    private void OnDisable()
    {
        healthComponent.OnChangeHp.RemoveAction(UpdateTxt);
    }

    public void Initialize()
    {        
        healthComponent.OnChangeHp.AddAction(UpdateTxt);
        UpdateTxt();
    }

    public void UpdateTxt()
    {
        text.text = healthComponent.Hp.Get.ToString();
    }
}
