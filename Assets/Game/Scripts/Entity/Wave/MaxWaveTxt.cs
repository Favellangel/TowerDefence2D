using TMPro;
using UnityEngine;

public class MaxWaveTxt : MonoBehaviour
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
        text.text = waveComponent.CountWave.ToString();
    }
}
