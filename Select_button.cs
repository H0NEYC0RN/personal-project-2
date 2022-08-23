using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Select_button : MonoBehaviour
{
    private GameObject Event;
    [SerializeField] int Type; // 1 - Left&Right / 2 - Dress / 3 - Ghacha / 4 - Adventrue
    [SerializeField] int ButtonNum; // Left - 1 Right - 2 / Dress 1 ~ 8 / Check - 1 Yes - 2 No - 3

    [SerializeField] GameObject Check_Message;
    [SerializeField] Text Check_text;

    private bool Top;

    private void Start()
    {
        Event = GameObject.Find("EventSystem");
    }

    private void OnMouseUp()
    {
        if (Type == 1) // List - Left&Right
        {
            if (ButtonNum == 1)
            {
                if (Event.GetComponent<Category>().Category_num != 1)
                {
                    Event.GetComponent<Category>().Category_num--;
                }
            }
            if (ButtonNum == 2)
            {
                if (Event.GetComponent<Category>().Category_num != 4) // 최대 카테고리 수
                {
                    Event.GetComponent<Category>().Category_num++;
                }
            }
        }
        if (Type == 2) // Dress
        {
            if (ButtonNum == 1)
            {
                if (Event.GetComponent<Data_Manager>().nowData.Dressed_Top != 1)
                {
                    Event.GetComponent<Data_Manager>().nowData.Dressed_Top = 1;
                    Top = true;
                }
                else if (Event.GetComponent<Data_Manager>().nowData.Dressed_Top == 1)
                {
                    Event.GetComponent<Data_Manager>().nowData.Dressed_Top = 0;
                    Top = false;
                }
            }
            if (ButtonNum == 2)
            {
                if (Event.GetComponent<Data_Manager>().nowData.Dressed_Top != 2)
                {
                    Event.GetComponent<Data_Manager>().nowData.Dressed_Top = 2;
                    Top = true;
                }
                else if (Event.GetComponent<Data_Manager>().nowData.Dressed_Top == 2)
                {
                    Event.GetComponent<Data_Manager>().nowData.Dressed_Top = 0;
                    Top = false;
                }
            }
            if (ButtonNum == 3)
            {
                if (Event.GetComponent<Data_Manager>().nowData.Dressed_Top != 3)
                {
                    Event.GetComponent<Data_Manager>().nowData.Dressed_Top = 3;
                    Top = true;
                }
                else if (Event.GetComponent<Data_Manager>().nowData.Dressed_Top == 3)
                {
                    Event.GetComponent<Data_Manager>().nowData.Dressed_Top = 0;
                    Top = false;
                }
            }
            if (ButtonNum == 4)
            {
                if (Event.GetComponent<Data_Manager>().nowData.Dressed_Top != 4)
                {
                    Event.GetComponent<Data_Manager>().nowData.Dressed_Top = 4;
                    Top = true;
                }
                else if (Event.GetComponent<Data_Manager>().nowData.Dressed_Top == 4)
                {
                    Event.GetComponent<Data_Manager>().nowData.Dressed_Top = 0;
                    Top = false;
                }
            }
            if (ButtonNum == 5)
            {
                if (Event.GetComponent<Data_Manager>().nowData.Dressed_Top != 5)
                {
                    Event.GetComponent<Data_Manager>().nowData.Dressed_Top = 5;
                    Top = true;
                }
                else if (Event.GetComponent<Data_Manager>().nowData.Dressed_Top == 5)
                {
                    Event.GetComponent<Data_Manager>().nowData.Dressed_Top = 0;
                    Top = false;
                }
            }
            if (ButtonNum == 6)
            {
                if (Event.GetComponent<Data_Manager>().nowData.Dressed_Top != 6)
                {
                    Event.GetComponent<Data_Manager>().nowData.Dressed_Top = 6;
                    Top = true;
                }
                else if (Event.GetComponent<Data_Manager>().nowData.Dressed_Top == 6)
                {
                    Event.GetComponent<Data_Manager>().nowData.Dressed_Top = 0;
                    Top = false;
                }
            }
            if (ButtonNum == 7)
            {
                if (Event.GetComponent<Data_Manager>().nowData.Dressed_Top != 7)
                {
                    Event.GetComponent<Data_Manager>().nowData.Dressed_Top = 7;
                    Top = true;
                }
                else if (Event.GetComponent<Data_Manager>().nowData.Dressed_Top == 7)
                {
                    Event.GetComponent<Data_Manager>().nowData.Dressed_Top = 0;
                    Top = false;
                }
            }
            if (ButtonNum == 8)
            {
                if (Event.GetComponent<Data_Manager>().nowData.Dressed_Top != 8)
                {
                    Event.GetComponent<Data_Manager>().nowData.Dressed_Top = 8;
                    Top = true;
                }
                else if (Event.GetComponent<Data_Manager>().nowData.Dressed_Top == 8)
                {
                    Event.GetComponent<Data_Manager>().nowData.Dressed_Top = 0;
                    Top = false;
                }
            }
        }
        if (Type == 3) // Ghacha
        {
            if (ButtonNum == 1)
            {
                Check_Message.SetActive(true);
                Check_text.text = "500골드가 소모됩니다.";
            }
            if (ButtonNum == 2)
            {
                Event.GetComponent<Ghacha>().isActived = true;
                Check_Message.SetActive(false);
            }
            if (ButtonNum == 3)
            {
                Check_Message.SetActive(false);
            }
        }

        if (Type == 4) // Adventure
        {
            if (Event.GetComponent<Data_Manager>().nowData.Timer_Actived == false)
            {
                if (Event.GetComponent<Timer>().Reward_A == true)
                {
                    if (ButtonNum == 1)
                    {
                        //보상관련코드
                        Debug.Log("보상수령완료");
                        Event.GetComponent<Timer>().Reward_A = false;
                    }
                }
                else
                {
                    if (ButtonNum == 1)
                    {
                        Check_Message.SetActive(true);
                        Check_text.text = "탐사 진행시,\n의상 변경이 불가능합니다.\n\n최대 탐사 가능 시간\n= 24시간";
                    }
                    if (ButtonNum == 2)
                    {
                        Event.GetComponent<Timer>().Start_Timer = true;
                        Event.GetComponent<Data_Manager>().nowData.Timer_Actived = true;
                        Check_Message.SetActive(false);
                    }
                    if (ButtonNum == 3)
                    {
                        Check_Message.SetActive(false);
                    }
                }

            }
        }
    }
}
