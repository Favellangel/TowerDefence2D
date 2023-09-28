using UnityEngine;

public class WaveSubscriber : MonoBehaviour
{
    private IEventable onNextWave;
    private GoldMinerUpdater goldMinerUpdater;
    private SpawnerComponent[] spawnerComponents;
    private BtnStartWaveBehavior btnStartWaveBehavior;

    private void Awake()
    {
        onNextWave = GetComponent<WaveComponent>();
        Player player = FindObjectOfType<Player>();

        spawnerComponents = FindObjectsOfType<SpawnerComponent>();
        goldMinerUpdater = player.GetComponent<GoldMinerUpdater>();
        btnStartWaveBehavior = FindObjectOfType<BtnStartWaveBehavior>(true);
    }

    private void OnEnable()
    {
        foreach (var spawner in spawnerComponents)
        {
            onNextWave.AddAction(spawner.StartSpawn);
        }

        onNextWave.AddAction(goldMinerUpdater.Activate);
        onNextWave.AddAction(btnStartWaveBehavior.SetDisable);       
    }

    private void OnDisable()
    {
        foreach (var spawner in spawnerComponents)
        {
            onNextWave.RemoveAction(spawner.StartSpawn);
        }

        onNextWave.RemoveAction(goldMinerUpdater.Activate);
        onNextWave.RemoveAction(btnStartWaveBehavior.SetDisable);
    }
}
