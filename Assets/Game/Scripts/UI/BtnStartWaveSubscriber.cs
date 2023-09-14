using UnityEngine;
using UnityEngine.UI;

public class BtnStartWaveSubscriber : MonoBehaviour
{
    private WaveComponent waveComponent;

    private void Awake()
    {
        waveComponent = FindObjectOfType<WaveComponent>(true);
    }

    private void OnEnable()
    {
        GetComponent<Button>().onClick.AddListener(Execute);
    }

    private void Execute()
    {
        waveComponent.NextWave();
    }
}
