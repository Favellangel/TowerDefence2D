using TMPro;
using UnityEngine;

public class CurrentGoldTxt : MonoBehaviour
{
    private TextMeshProUGUI text;
    private GoldComponent goldComponent;

    private void Awake()
    {
        Player player = FindObjectOfType<Player>();
        goldComponent = player.GetComponent<GoldComponent>();

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
