using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI : MonoBehaviour
{
    [SerializeField] int Scean_num;

    [SerializeField] Text Gold;
    [SerializeField] Text Timer_Text;

    void Update()
    {
        Scean_num = GameObject.Find("Scean_Manager").GetComponent<Scean_num>().SceanNum;

        if (Scean_num == 1)
        {
            Gold.text = this.GetComponent<Data_Manager>().nowData.Money.ToString();
            Gold = GameObject.Find("Gold_Text").GetComponent<Text>();
        }
        if (Scean_num == 2)
        {
            Timer_Text = GameObject.Find("Time_Text").GetComponent<Text>();

            if(this.GetComponent<Data_Manager>().nowData.Timer_Actived == false)
            {
                Timer_Text.text = "";
            }
            else if (this.GetComponent<Timer>().Time_current < 1)
            {
                Timer_Text.text = $"{this.GetComponent<Timer>().Time_current * 60 :N0}" + " 초째";
            }
            else if (this.GetComponent<Timer>().Time_current < this.GetComponent<Timer>().Time_Max)
            {
                Timer_Text.text = $"{this.GetComponent<Timer>().Time_current :N1}" + " 분째";
            }
        }
    }
}