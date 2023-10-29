using UnityEngine;

public class MenuDatasBehavior : MonoBehaviour, IAwakable
{
    private MainMenuData datas;

    public int CountOpenLvl => datas.countOpenLvl;

    public void Initialize()
    {
        datas = new MainMenuData();
        datas.countOpenLvl = 1;
    }
    public MainMenuData GetDatas()
    {
        return datas;
    }

    public void SetDatas(MainMenuData datas)
    {
        this.datas = datas;
    }

    public void SetCountOpenLvl(int countOpenLvl)
    {
        if (countOpenLvl <= datas.countOpenLvl) return;
        datas.countOpenLvl = countOpenLvl;
    }
}
