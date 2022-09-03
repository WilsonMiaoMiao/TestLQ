using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveAndLoad : MonoBehaviour
{
public void Save()
    {
        SaveSystem.SaveData();
    }
    public void Load()
    {
        SaveSystem.LoadData();
    }
}
