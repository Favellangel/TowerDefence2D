
public class BtnTowerAreaUpgradeSubscriber : BtnSubscriber
{
    private PanelUpgradeController panelUpgradeController;

    protected override void Awake()
    {
        base.Awake();
        panelUpgradeController = GetComponentInParent<PanelUpgradeController>();
    }

    protected override void Execute()
    {
        if (panelUpgradeController.Tower == false) return;
        
        bool isUpgrade = panelUpgradeController.Tower.RadiusAttackComponent.NextLvl();

        if(isUpgrade == false) 
            btn.interactable= false;
    }
}
