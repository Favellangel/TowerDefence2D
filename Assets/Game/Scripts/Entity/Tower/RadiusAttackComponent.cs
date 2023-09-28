using UnityEngine;

public class RadiusAttackComponent : MonoBehaviour
{
    [SerializeField] private float radiusAttack;

    [SerializeField] private int lvl;
    [SerializeField] private int maxLvl;

    private void OnEnable()
    {
        transform.localScale = Vector2.one * radiusAttack;
    }

    public bool Increase(int countAdded)
    {
        if(lvl == maxLvl) return false;

        lvl++;
        radiusAttack += countAdded;
        transform.localScale = Vector2.one * radiusAttack;
        return true;
    }
}
