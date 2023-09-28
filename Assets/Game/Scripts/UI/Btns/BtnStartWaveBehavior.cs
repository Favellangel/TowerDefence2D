using UnityEngine;
public class BtnStartWaveBehavior : BtnSubscriber
{
    [SerializeField] private float delayBtnShow;    
    [SerializeField] private float delayWaveRestart;    

    private WaveComponent waveComponent;

    protected override void Awake()
    {
        base.Awake();
        waveComponent = FindObjectOfType<WaveComponent>(true);
    }

    protected override void OnEnable()
    {
        base.OnEnable();
        waveComponent.AddActionNextWave(SetDisable);
    }

    protected override void Execute()
    {
        waveComponent.NextWave();
        CancelInvoke(nameof(Execute));
    }

    private void SetDisable()
    {
        Invoke(nameof(SetEnable), delayBtnShow);
        gameObject.SetActive(false);
    }

    private void SetEnable()
    {
        gameObject.SetActive(true);
        Invoke(nameof(Execute), delayWaveRestart);
    }
}
