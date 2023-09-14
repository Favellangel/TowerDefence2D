using UnityEngine;

public class Spawner_Subscriber : MonoBehaviour
{
    private WaveComponent waveComponent;
    private SpawnerComponent spawnerComponent;


    private void Awake()
    {
        spawnerComponent = GetComponent<SpawnerComponent>();
        waveComponent = FindObjectOfType<WaveComponent>(true);
    }

    private void OnEnable()
    {
        waveComponent.AddActionNextWave(spawnerComponent.SatrtSpawn);
    }
}
