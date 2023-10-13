using UnityEngine;

public class RadiusAttackComponent : MonoBehaviour
{
    [SerializeField] private float radiusAttack;

    [SerializeField] private int lvl;
    [SerializeField] private int maxLvl;

    public float RadiusAttack => radiusAttack;

    private void OnEnable()
    {
        transform.localScale = Vector2.one * radiusAttack;
    }

    public bool IsMaxLvl()
    {
        if (lvl == maxLvl) return true;

        return false;
    }

    public void Increase(int countAdded)
    {
        lvl++;
        radiusAttack += countAdded;
        transform.localScale = Vector2.one * radiusAttack;
    }
}
