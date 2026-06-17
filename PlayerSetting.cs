using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSetting : MonoBehaviour
{
    //玩家中需要保存的数据
    [Serializable]
    public class SaveData
    {
        public string name;
        public float speed;
        public int atk;
    };
    private SaveData saveData = new SaveData();

    public void Save(Player player)
    {
        saveData.name = player.Name;
        saveData.speed = player.Speed;
        saveData.atk = player.Atk;

        SaveSystem.SaveByPlayerPrefs("saveData", saveData);
    }
    public SaveData Load()
    {
        SaveData saveData = SaveSystem.LoadByPlayerPrefs<SaveData>("saveData");
        return saveData;
    }
}
