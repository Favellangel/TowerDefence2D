using System;
using UnityEngine;

public class HealthComponent : MonoBehaviour, IEventable
{
    [SerializeField] private Property<int> hp;
    [SerializeField] private Property<int> maxHp;

    private Action onDie;
    Action IEventable.OnChange { get => onDie; set => onDie = value; }

    #region Внешние поля

    public ActionAbstract OnChangeHp => hp;
    public ActionAbstract OnChangeMaxHp => maxHp;

    public IGettable<int> Hp => hp;
    public IGettable<int> MaxHp => maxHp;
    #endregion

    public void Initialize(int hp, int maxHp)
    {
        this.hp.Set = hp;
        this.maxHp.Set = maxHp;
    }

    public void TakeDamage(int damage)
    {
        int tmp = hp.Get - damage;

        if (tmp > 0) hp.Set = tmp;
        else
        {
            hp.Set = 0;
            onDie?.Invoke();
        }
    }
}
