using System;
using UnityEngine;

public class WaveComponent : MonoBehaviour, IEventable
{
    [SerializeField] private int currentWave;
    [SerializeField] private int countWave;

    private static WaveComponent instance;

    private Action onNextWave;
    Action IEventable.OnChange { get => onNextWave; set => onNextWave = value; }

    public int CurrentWave => currentWave;
    public int CountWave => countWave;


    private void Awake()
    {
        if (instance == null)
            instance = this;
        else
            gameObject.SetActive(false);        
    }

    public void AddActionNextWave(Action action)
    {
        //onNextWave += action;
    }

    public void RemoveActionNextWave(Action action)
    {
        //onNextWave -= action;
    }

    public void NextWave()
    {
        if (currentWave >= countWave)
            return;

        currentWave++;
        onNextWave?.Invoke();
    }
}
