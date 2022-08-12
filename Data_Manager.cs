using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class Data_Manager : MonoBehaviour
{
    public Data nowData = new Data();
    private string Data_Path;
    private string Data_name;
    private bool Save_Delay = false;

    private void Awake()
    {
        //게임오브젝트가 다른 Scnen으로 전환되어도 파괴되지 않도록 함
        DontDestroyOnLoad(this.gameObject);

        //초기 자금값 설정
        nowData.Money = 5000;

        Data_Path = Application.persistentDataPath + "/";
        Data_name = "Player_Data";

        string PL_Data = File.ReadAllText(Data_Path + Data_name);
        nowData = JsonUtility.FromJson<Data>(PL_Data);
        Debug.Log("First " + PL_Data);
    }

    private void Update()
    {
        if (Save_Delay == false)
        {
            Save();
        }

        //정상 작동 확인용 임시 돈치트
        if (Input.GetKeyDown(KeyCode.E))
        {
            nowData.Money += 500;
        }
    }

    private void Save()
    {
        string PL_Data = JsonUtility.ToJson(nowData);
        File.WriteAllText(Data_Path + Data_name, PL_Data);

        Debug.Log(PL_Data);

        Save_Delay = true;
        Invoke("Save_Delay_ON", 3f);
    }

    private void Save_Delay_ON()
    {
        Save_Delay = false;
    }
}
