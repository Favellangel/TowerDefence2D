using TMPro;
using UnityEngine;

public class CurrentGoldTxtOLD : MonoBehaviour
{
    private TextMeshProUGUI text;
    private GoldComponent goldComponent;

    private void Awake()
    {
        text = GetComponent<TextMeshProUGUI>();
        Player player = FindObjectOfType<Player>(true);       
        goldComponent = player.GetComponent<GoldComponent>();
    }

    private void OnEnable()
    {
        goldComponent.OnChangeGold.AddAction(UpdateTxt);
        UpdateTxt();
    }

    private void OnDisable()
    {
        goldComponent.OnChangeGold.RemoveAction(UpdateTxt);
    }

    private void OnDestroy()
    {
        goldComponent.OnChangeGold.RemoveAction(UpdateTxt);
    }

    public void UpdateTxt()
    {
        text.text = goldComponent.Gold.Get.ToString(); 
    }
}
