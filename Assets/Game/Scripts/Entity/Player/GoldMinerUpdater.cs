using UnityEngine;

public class GoldMinerUpdater : MonoBehaviour
{
    [SerializeField] private float delay;

    [SerializeField] private int lvl;
    [SerializeField] private int maxLvl;
    [SerializeField] private int countAddedGold;

    private bool isMine;

    private int addedGold;

    private float currentDelay;


    private GoldComponent goldComponent;

    private void Awake()
    {
        Player player = FindObjectOfType<Player>();
        goldComponent = player.GetComponent<GoldComponent>();
    }

    private void Update()
    {
        if (isMine == false) return;

        if (currentDelay <= 0)
        {
            currentDelay = delay;
            goldComponent.AddGold(countAddedGold + addedGold);
        }
        else
            currentDelay -= Time.deltaTime;
    }

    public void Activate()
    {
        if (isMine) return;

        isMine = true;
    }

    public void NextLvl()
    {
        lvl++;
        addedGold++;
    }

    public bool CanLvlUp()
    {
        if (lvl < maxLvl) return true;

        return false;
    }
}
