using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine;

public class SaveComponent 
{
    BinaryFormatter bf = new BinaryFormatter();

    public void SaveDatas(GameDatasForSave gameDatasForSave)
    {
        FileStream fileStream = File.Create(Application.persistentDataPath + "/PlayerData.dat");

        bf.Serialize(fileStream, gameDatasForSave); 
        fileStream.Close();
        Debug.Log("������ ������ ���������");
    }

    public GameDatasForSave LoadDatas()
    {
        if (File.Exists(Application.persistentDataPath + "/PlayerData.dat"))
        {
            FileStream fileStream = File.Open(Application.persistentDataPath + "/PlayerData.dat", FileMode.Open);
            GameDatasForSave gameDatasForSave = (GameDatasForSave)bf.Deserialize(fileStream); 
            fileStream.Close();
            Debug.Log("������ ������ ���������");
            return gameDatasForSave;
        }
        else
        {
            Debug.Log("������ ������ ��� �������� �� �������");
            return null;
        }
    }

    public void DeleteDatas()
    {
        if (File.Exists(Application.persistentDataPath + "/PlayerData.dat"))
        {
            File.Delete(Application.persistentDataPath + "/PlayerData.dat");
            Debug.Log("������ ������ �������");
        }
        else
        {
            Debug.Log("������ ������ ��� �������� �� �������");
        }
    }
}
