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
        if (Scean_num == 1)
        {
            Gold.text = this.GetComponent<Data_Manager>().nowData.Money.ToString();
        }
        if (Scean_num == 2)
        {
            if (this.GetComponent<Timer>().Time_current < 60)
            {
                Timer_Text.text = $"{this.GetComponent<Timer>().Time_current * 60:N0}" + " 초째";
            }
            else if (this.GetComponent<Timer>().Time_current < this.GetComponent<Timer>().Time_Max)
            {
                Timer_Text.text = $"{this.GetComponent<Timer>().Time_current :N1}" + " 분째";
            }
        }
    }
}