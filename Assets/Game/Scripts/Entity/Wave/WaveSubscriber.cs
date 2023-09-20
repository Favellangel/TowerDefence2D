using UnityEngine;

public class WaveSubscriber : MonoBehaviour
{
    private WaveComponent waveComponent;
    private GoldMinerUpdater goldMinerUpdater;
    private SpawnerComponent[] spawnerComponents;

    private void Awake()
    {
        Player player = FindObjectOfType<Player>();
        waveComponent = GetComponent<WaveComponent>();
        spawnerComponents = FindObjectsOfType<SpawnerComponent>();
        goldMinerUpdater = player.GetComponent<GoldMinerUpdater>();
    }

    private void OnEnable()
    {
        foreach (var spawner in spawnerComponents)
        {
            waveComponent.AddActionNextWave(spawner.StartSpawn);
        }
        waveComponent.AddActionNextWave(goldMinerUpdater.Activate);
    }
}
