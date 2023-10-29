
public class SaveLoadBehavior
{
    private SaveComponent saveComponent;
    private SaveDataCollector saveDataCollector;

    public SaveLoadBehavior(MenuDatasBehavior menuDatasBehavior)
    {
        saveComponent = new SaveComponent();
        saveDataCollector =  new SaveDataCollector(menuDatasBehavior);
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
