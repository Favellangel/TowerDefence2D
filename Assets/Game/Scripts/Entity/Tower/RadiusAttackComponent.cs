using UnityEngine;

public class RadiusAttackComponent : MonoBehaviour
{
    [SerializeField] private float radiusAttack;

    [SerializeField] private int lvl;
    [SerializeField] private int maxLvl;
    [SerializeField] private int countAdded;

    private void OnEnable()
    {
        transform.localScale = Vector2.one * radiusAttack;
    }

    public bool NextLvl()
    {
        if(lvl == maxLvl) return false;

        lvl++;
        radiusAttack += countAdded;
        transform.localScale = Vector2.one * radiusAttack;
        return true;
    }
}
