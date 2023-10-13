using UnityEngine;

public class SaveDataCollector : MonoBehaviour, IAwakable
{
    private MenuDatasBehavior menuDatas;

    public void Initialize()
    {
        menuDatas = FindObjectOfType<MenuDatasBehavior>();
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
