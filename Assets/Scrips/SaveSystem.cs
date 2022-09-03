using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public static class SaveSystem 
{
    public static void SaveByjson(string fileName,object data)
    {
       string json = JsonUtility.ToJson(data);
        string path =Path.Combine(Application.persistentDataPath,fileName);
        File.WriteAllText(path,json);
    }
    public static T LoadByjson<T>(string fileName)
    {
        string path = Path.Combine(Application.persistentDataPath, fileName);
        string json = File.ReadAllText(path);
        T data =JsonUtility.FromJson<T>(json);
        return data;
    }

    public static void DeleteByjson(string fileName)
    {
        string path = Path.Combine(Application.persistentDataPath, fileName);
        File.Delete(path);
    }


    public static void SaveData()
    {
        TestGameData testGameData = new TestGameData();
        testGameData.hp = 10;
        SaveByjson("WYF", testGameData);
        Debug.Log(testGameData.hp);
        Debug.Log(testGameData.name);
    }
    public static void LoadData()
    {
      TestGameData testGameData =  LoadByjson<TestGameData>("WYF");
        Debug.Log(testGameData.hp);
        Debug.Log(testGameData.name);
    }
}
