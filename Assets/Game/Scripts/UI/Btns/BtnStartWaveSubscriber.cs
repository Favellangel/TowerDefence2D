public class BtnStartWaveSubscriber : BtnSubscriber
{
    private WaveComponent waveComponent;

    protected override void Awake()
    {
        base.Awake();
        waveComponent = FindObjectOfType<WaveComponent>(true);
    }

    protected override void Execute()
    {
        waveComponent.NextWave();
    }
}
