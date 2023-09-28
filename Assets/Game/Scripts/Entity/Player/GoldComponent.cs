using UnityEngine;

public class GoldComponent : MonoBehaviour
{
    [SerializeField] private Property<int> gold;
    [SerializeField] private int maxGold;

    public ActionAbstract OnChangeGold => gold;
    public IGettable<int> Gold => gold;

    public void AddGold(int addedGold)
    {
        int tmp = gold.Get + addedGold;
        if(tmp < maxGold)
        {
            gold.Set = tmp;
        }
        else
            gold.Set = maxGold;
    }

    public bool SubGold(int subGold)
    {
        int tmp = gold.Get - subGold;
        
        if (tmp >= 0)
        {
            gold.Set = tmp;
            return true;
        }

        return false;
    }
}
