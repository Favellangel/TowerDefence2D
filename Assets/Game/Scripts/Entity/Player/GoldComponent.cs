using UnityEngine;

public class GoldComponent : MonoBehaviour
{
    [SerializeField] private Property<int> gold;
    [SerializeField] private int maxGold;

    //////////// ÂÍÅØÍÈÅ ÏÎËß //////////////////
    public ActionAbstract OnChangeGold => gold;
    public IGettable<int> Gold => gold;

    public bool AddGold(int addedGold)
    {
        int tmp = gold.Get + addedGold;
        if(tmp < maxGold)
        {
            gold.Set = tmp;
            return true;
        }

        return false;
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
