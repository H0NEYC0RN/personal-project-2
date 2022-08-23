using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Check_Cheat : MonoBehaviour
{
    void Update()
    {
        //정상 작동 확인용 임시 치트
        if (Input.GetKeyDown(KeyCode.Q))
        {
            this.GetComponent<Data_Manager>().nowData.Money = this.GetComponent<Data_Manager>().First_Money;
            this.GetComponent<Data_Manager>().nowData.Item.Clear();
            this.GetComponent<Data_Manager>().nowData.Set_Item.Clear();
            this.GetComponent<Data_Manager>().nowData.Timer_Actived = false;
            this.GetComponent<Data_Manager>().nowData.Timer_start = 0;
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            this.GetComponent<Data_Manager>().nowData.Timer_start -= 50;
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            this.GetComponent<Data_Manager>().nowData.Money += 500;
        }
    }
}
