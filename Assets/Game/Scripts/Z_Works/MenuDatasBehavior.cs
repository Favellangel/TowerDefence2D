using UnityEngine;

public class MenuDatasBehavior : MonoBehaviour, IAwakable
{
    private MainMenuData datas;

    public void Initialize()
    {
        datas = new MainMenuData();
        datas.countOpenLvl = 1;
        DontDestroyOnLoad(this);
    }
    public MainMenuData GetDatas()
    {
        return datas;
    }

    public void SetDatas(MainMenuData datas)
    {
        this.datas = datas;
        print(datas.countOpenLvl);
    }
}
