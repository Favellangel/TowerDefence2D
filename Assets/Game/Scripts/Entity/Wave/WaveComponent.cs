using UnityEngine;

public class WaveComponent : MonoBehaviour
{
    [SerializeField] private Variable<int> currentWave;
    [SerializeField] private int countWave;

    private static WaveComponent instance;

    public IGettable<int> Wave => currentWave;
    public IEventable onChangeWave => currentWave;
    public IStringable WaveTxt => currentWave;
    public int CountWave => countWave;


    private void Awake()
    {
        if (instance == null) instance = this;
        else gameObject.SetActive(false);        
    }

    public void NextWave()
    {
        if (currentWave.Get >= countWave) return;
        currentWave.Set = currentWave.Get + 1;
    }
}
