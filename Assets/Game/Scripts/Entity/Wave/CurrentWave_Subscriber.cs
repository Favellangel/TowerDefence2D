using TMPro;
using UnityEngine;

public class CurrentWave_Subscriber : MonoBehaviour
{
    private TextMeshProUGUI text;
    private WaveComponent waveComponent;

    private void Awake()
    {
        waveComponent = FindObjectOfType<WaveComponent>(true);
        text = GetComponent<TextMeshProUGUI>();
    }

    private void OnEnable()
    {
        Initialize();
    }

    private void OnDisable()
    {
        waveComponent.RemoveActionNextWave(UpdateTxt);
    }

    public void Initialize()
    {
        waveComponent.AddActionNextWave(UpdateTxt);
        UpdateTxt();
    }

    public void UpdateTxt()
    {
        text.text = waveComponent.CurrentWave.ToString();
    }
}
