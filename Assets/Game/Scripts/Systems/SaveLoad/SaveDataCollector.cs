
public class SaveDataCollector 
{
    private MenuDatasBehavior menuDatas;

    public SaveDataCollector(MenuDatasBehavior menuDatas)
    {
        this.menuDatas = menuDatas;
    }

    public GameDatasForSave GetData()
    {
        GameDatasForSave datas = new()
        {
            mainMenuData = menuDatas.GetDatas()
        };

        return datas;
    }

    public void SetData(GameDatasForSave gameDatasForSave)
    {
        menuDatas.SetDatas(gameDatasForSave.mainMenuData);
    }
}
