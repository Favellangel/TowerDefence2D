using TMPro;
using UnityEngine;

public class CurrentGold_Subscriber : MonoBehaviour
{
    private TextMeshProUGUI text;
    private GoldComponent goldComponent;

    private void Awake()
    {
        goldComponent = FindObjectOfType<GoldComponent>(true);

        text = GetComponent<TextMeshProUGUI>();
    }

    private void OnEnable()
    {
        Initialize();
    }

    private void OnDisable()
    {
        goldComponent.OnChangeGold.RemoveAction(UpdateTxt);
    }

    public void Initialize()
    {
        goldComponent.OnChangeGold.AddAction(UpdateTxt);
        UpdateTxt();
    }

    public void UpdateTxt()
    {
        text.text = goldComponent.Gold.Get.ToString();
    }
}
