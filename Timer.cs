using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{

    public float Time_Max = 1440;
    private float Time_start;
    public float Time_current;

    private bool isEnded;

    private void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }

    private void Update()
    {
        //Timer 시작 조건 추가 필요
        if (!isEnded)
        {
            Reset_Timer();
        }

        if (isEnded)
        {
            return;
        }

        Timer_Check();

        this.GetComponent<Data_Manager>().nowData.Timer = Time_current;
    }

    private void Timer_Check()
    {
        // 현재 타이머 시간 = 시작 시간 (0시간 0분) + 현재 시간
        Time_current = ((float)System.DateTime.Now.TimeOfDay.TotalSeconds - Time_start)/60;


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
    }

    private void Reset_Timer()
    {
        Time_start = (float)System.DateTime.Now.TimeOfDay.TotalSeconds;
        Time_current = 0;
        isEnded = false;
    }
}
