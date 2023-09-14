using System;
using UnityEngine;

public class HealthComponent : MonoBehaviour
{
    [SerializeField] private Property<int> hp;
    [SerializeField] private Property<int> maxHp;

    private Action onDie;

    //////////// ÂÍÅØÍÈÅ ÏÎËß //////////////////
    public ActionAbstract OnChangeHp => hp;
    public ActionAbstract OnChangeMaxHp => maxHp;

    public IGettable<int> Hp => hp;
    public IGettable<int> MaxHp => maxHp;

    //______________________________________________

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

    public void AddActionOnDie(Action action)
    {
        onDie += action;
    }

    public void RemoveActionOnDie(Action action)
    {
        onDie -= action;
    }
}
