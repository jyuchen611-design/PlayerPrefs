using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.RestService;
using UnityEngine;

public static class SaveSystem
{
    //保存任意数据类型
    public static void SaveByPlayerPrefs(string key,object data)
    {
        //将所有类型统一转为String类型来保存
        string json = JsonUtility.ToJson(data);
        PlayerPrefs.SetString(key,json);
        PlayerPrefs.Save();
    }

    //读取特定类型
    public static T LoadByPlayerPrefs<T>(string key)
    {
       string json = PlayerPrefs.GetString(key);
       T data = JsonUtility.FromJson<T>(json);
       return data;
    }
}
