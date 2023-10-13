using UnityEngine;

public class SaveLoadBehavior : MonoBehaviour, IAwakable
{
    private SaveComponent saveComponent;
    private SaveDataCollector saveDataCollector;

    public void Initialize()
    {
        saveComponent = new SaveComponent();
        saveDataCollector = GetComponent<SaveDataCollector>();
    }

    public void SaveGame()
    {
        GameDatasForSave gameDatasForSave = saveDataCollector.GetData();
        saveComponent.SaveDatas(gameDatasForSave);
    }

    public void LoadGame()
    {
        GameDatasForSave gameDatasForSave = saveComponent.LoadDatas();
        if (gameDatasForSave == null) return;
        saveDataCollector.SetData(gameDatasForSave);
    }

    public void DeleteDatas()
    {
        saveComponent.DeleteDatas();
    }
}
