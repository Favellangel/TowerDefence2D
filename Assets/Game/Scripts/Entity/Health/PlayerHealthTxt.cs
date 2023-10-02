using TMPro;
using UnityEngine;

public class PlayerHealthTxt : TxtMeshUpdater
{
    private HealthComponent healthComponent;

    protected override void Awake()
    {
        base.Awake();

        Player player = FindObjectOfType<Player>(true);
        healthComponent = player.GetComponent<HealthComponent>();

        onChange = healthComponent.onChangeHp;
        currentTxt = healthComponent.HpTxt;
    }
}
