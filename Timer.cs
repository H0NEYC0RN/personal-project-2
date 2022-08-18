using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{

    public float Time_Max = 1440;
    public float Time_start;
    public float Time_current;

    private bool isEnded = false;
    public bool Start_Timer = false;

    private void Update()
    {
        //Timer 시작용 체크용 임시 코드
        if ( Input.GetKeyDown(KeyCode.Space) )
        {
            this.GetComponent<Data_Manager>().nowData.Timer_Actived = true;
        }
        
        if (Start_Timer)
        {
            if (!isEnded)
            {
                Reset_Timer();
            }
            if (isEnded)
            {
                return;
            }
        }

        if (this.GetComponent<Data_Manager>().nowData.Timer_Actived)
        {
            Timer_Check();
        }
    }

    private void Timer_Check()
    {
        // 현재 타이머 시간 = 현재 시간 - 시작 시간
        Time_current = ((float)System.DateTime.Now.TimeOfDay.TotalSeconds - this.GetComponent<Data_Manager>().nowData.Timer_start) /60;


        if (Time_current > Time_Max)
        {
            if (!isEnded)
            {
                End_Timer();
            }
        }
    }

    private void End_Timer()
    {
        Time_current = Time_Max;
        isEnded = true;
        this.GetComponent<Data_Manager>().nowData.Timer_Actived = false;
    }

    private void Reset_Timer()
    {
        Time_start = (float)System.DateTime.Now.TimeOfDay.TotalSeconds;
        this.GetComponent<Data_Manager>().nowData.Timer_start = Time_start;
        Time_current = 0;
        isEnded = false;
        Start_Timer = false;
    }
}
