using TMPro;
using UnityEngine;

public class CurrentWaveTxt : MonoBehaviour
{
    private TextMeshProUGUI text;
    private WaveComponent waveComponent;
    private IEventable onNextWave;

    private void Awake()
    {
        waveComponent = FindObjectOfType<WaveComponent>(true);
        onNextWave= FindObjectOfType<WaveComponent>(true);
        text = GetComponent<TextMeshProUGUI>();
    }

    private void OnEnable()
    {
        waveComponent.AddActionNextWave(UpdateTxt);
        onNextWave.AddAction(UpdateTxt);
        UpdateTxt();
    }

    private void OnDisable()
    {
        waveComponent.RemoveActionNextWave(UpdateTxt);
        onNextWave.RemoveAction(UpdateTxt);
    }

    private void OnDestroy()
    {
        waveComponent.RemoveActionNextWave(UpdateTxt);
        onNextWave.RemoveAction(UpdateTxt);
    }

    public void UpdateTxt()
    {
        text.text = waveComponent.CurrentWave.ToString();
    }
}
