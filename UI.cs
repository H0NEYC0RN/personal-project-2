using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI : MonoBehaviour
{
    [SerializeField] int Scean_num;

    [SerializeField] Text Gold;
    [SerializeField] Text Timer_Text;

    private bool Find_Timer_button_A;
    private bool Timer_button_1;
    [SerializeField] GameObject Timer_button_A;

    void Update()
    {
        Scean_num = GameObject.Find("Scene_Manager").GetComponent<Scene_num>().SceneNum;

        if (Scean_num == 1)
        {
            Gold.text = this.GetComponent<Data_Manager>().nowData.Money.ToString();
            Gold = GameObject.Find("Gold_Text").GetComponent<Text>();
        }
        if (Scean_num == 2)
        {
            if (Find_Timer_button_A == false)
            {
                if (Timer_button_A == null)
                {
                    Timer_button_A = GameObject.Find("Active_button");
                    Find_Timer_button_A = true;
                }
            }

            Timer_Text = GameObject.Find("Time_Text").GetComponent<Text>();

            if (this.GetComponent<Data_Manager>().nowData.Timer_Actived == false)
            {
                if (this.GetComponent<Timer>().Reward_A == true)
                {
                    Timer_Text.text = "탐사완료";
                }
                else
                {
                    Timer_Text.text = "";
                }
            }
            else if (this.GetComponent<Timer>().Time_current < 1)
            {
                Timer_Text.text = $"{this.GetComponent<Timer>().Time_current * 60 :N0}" + " 초째";
            }
            else if (this.GetComponent<Timer>().Time_current < this.GetComponent<Timer>().Time_Max)
            {
                Timer_Text.text = $"{this.GetComponent<Timer>().Time_current :N1}" + " 분째";
            }

            if (Timer_button_1 == false)
            {
                if (this.GetComponent<Data_Manager>().nowData.Timer_Actived == true)
                {
                    Timer_button_A.SetActive(false);
                    Timer_button_1 = true;
                }
            }
            if (this.GetComponent<Data_Manager>().nowData.Timer_Actived == false)
            {
                Timer_button_A.SetActive(true);
                Timer_button_1 = false;
            }
        }
    }
}