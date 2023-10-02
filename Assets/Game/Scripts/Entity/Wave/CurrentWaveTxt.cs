
public class CurrentWaveTxt : TxtMeshUpdater
{
    private WaveComponent waveComponent;

    protected override void Awake()
    {
        base.Awake();

        waveComponent = FindObjectOfType<WaveComponent>(true);
        
        onChange = waveComponent.onChangeWave;
        currentTxt = waveComponent.WaveTxt;
    }
}
