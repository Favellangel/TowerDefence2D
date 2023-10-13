using TMPro;

public class CurrentGoldTxtOLD : Subscriber, IAwakable
{
    private TextMeshProUGUI text;
    private GoldComponent goldComponent;

    public void Initialize()
    {
        text = GetComponent<TextMeshProUGUI>();
        Player player = FindObjectOfType<Player>(true);
        goldComponent = player.GetComponent<GoldComponent>();
        onAction = player.GetComponent<GoldComponent>().OnChangeGold;
    }

    public override void Execute()
    {
        text.text = goldComponent.Gold.Get.ToString();
    }
}
