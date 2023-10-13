using UnityEngine;

public class WaveSubscriber : MonoBehaviour
{
    private IEventable onNextWave;
    private GoldMinerUpdater goldMinerUpdater;
    private SpawnerComponent[] spawnerComponents;
    private BtnStartWave btnStartWaveBehavior;

    private void Awake()
    {
        onNextWave = GetComponent<WaveComponent>().onChangeWave;
        Player player = FindObjectOfType<Player>();

        spawnerComponents = FindObjectsOfType<SpawnerComponent>();
        goldMinerUpdater = player.GetComponent<GoldMinerUpdater>();
        btnStartWaveBehavior = FindObjectOfType<BtnStartWave>(true);
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
