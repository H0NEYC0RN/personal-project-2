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

    public int First_Money = 1000;
    public string PL_Data; //디버그용 purblic -> 최종 빌드에서 private로 변경 필요

    private void Awake()
    {
        //게임오브젝트가 다른 Scnen으로 전환되어도 파괴되지 않도록 함
        DontDestroyOnLoad(this.gameObject);

        //데이터 경로 및 이름 지정
        Data_name = "Player_Data";
        Data_Path = Application.dataPath + Data_name + ".Json";
    }

    private void Start()
    {
        Load();
    }

    private void Update()
    {
        if (Save_Delay == false)
        {
            Save();
        }
    }
    
    private void Save()
    {
        string PL_Data = JsonUtility.ToJson(nowData);
        File.WriteAllText(Data_Path, PL_Data);

        //자동 저장 주기 조정
        Save_Delay = true;
        Invoke("Save_Delay_ON", 2f);
    }

    private void Save_Delay_ON()
    {
        Save_Delay = false;
    }

    private void Load()
    {
        //최초 실행 데이터 생성
        if (!File.Exists(Data_Path))
        {
            nowData.Money = First_Money;
            nowData.Item.Clear();
            nowData.Set_Item.Clear();
            nowData.Timer_Actived = false;
            nowData.Timer_start = 0;
            nowData.Dressed_Top = 0;
            string PL_Data = JsonUtility.ToJson(nowData);

            Debug.Log("최초 실행 데이터 생성 : " + PL_Data);
            Save();
        }
        else
        {
            //데이터 불러오기
            PL_Data = File.ReadAllText(Data_Path + Data_name);
            nowData = JsonUtility.FromJson<Data>(PL_Data);
            Debug.Log("데이터 불러오기 완료 : " + PL_Data);
        }
    }
}