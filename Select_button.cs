using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Select_button : MonoBehaviour
{
    [SerializeField] GameObject Event;
    [SerializeField] int Type; // 1 - Left&Right / 2 - Dress
    [SerializeField] int ButtonNum; // Left - 1 Right - 2 / Dress 1 ~ 8

    private bool Top;

    private void OnMouseUp()
    {
        if (Type == 1)
        {
            if (ButtonNum == 1)
            {
                if ( Event.GetComponent<Category>().Category_num != 1)
                {
                    Event.GetComponent<Category>().Category_num --;
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
        if (Type == 2)
        {
            if (ButtonNum == 1)
            {
                if (Event.GetComponent<State>().Dress_Top != 1)
                {
                    Event.GetComponent<State>().Dress_Top = 1;
                    Top = true;
                }
                else if (Event.GetComponent<State>().Dress_Top == 1)
                {
                    Event.GetComponent<State>().Dress_Top = 0;
                    Top = false;
                }
            }
            if (ButtonNum == 2)
            {
                if (Event.GetComponent<State>().Dress_Top != 2)
                {
                    Event.GetComponent<State>().Dress_Top = 2;
                    Top = true;
                }
                else if (Event.GetComponent<State>().Dress_Top == 2)
                {
                    Event.GetComponent<State>().Dress_Top = 0;
                    Top = false;
                }
            }
            if (ButtonNum == 3)
            {
                if (Event.GetComponent<State>().Dress_Top != 3)
                {
                    Event.GetComponent<State>().Dress_Top = 3;
                    Top = true;
                }
                else if (Event.GetComponent<State>().Dress_Top == 3)
                {
                    Event.GetComponent<State>().Dress_Top = 0;
                    Top = false;
                }
            }
            if (ButtonNum == 4)
            {
                if (Event.GetComponent<State>().Dress_Top != 4)
                {
                    Event.GetComponent<State>().Dress_Top = 4;
                    Top = true;
                }
                else if (Event.GetComponent<State>().Dress_Top == 4)
                {
                    Event.GetComponent<State>().Dress_Top = 0;
                    Top = false;
                }
            }
            if (ButtonNum == 5)
            {
                if (Event.GetComponent<State>().Dress_Top != 5)
                {
                    Event.GetComponent<State>().Dress_Top = 5;
                    Top = true;
                }
                else if (Event.GetComponent<State>().Dress_Top == 5)
                {
                    Event.GetComponent<State>().Dress_Top = 0;
                    Top = false;
                }
            }
            if (ButtonNum == 6)
            {
                if (Event.GetComponent<State>().Dress_Top != 6)
                {
                    Event.GetComponent<State>().Dress_Top = 6;
                    Top = true;
                }
                else if (Event.GetComponent<State>().Dress_Top == 6)
                {
                    Event.GetComponent<State>().Dress_Top = 0;
                    Top = false;
                }
            }
            if (ButtonNum == 7)
            {
                if (Event.GetComponent<State>().Dress_Top != 7)
                {
                    Event.GetComponent<State>().Dress_Top = 7;
                    Top = true;
                }
                else if (Event.GetComponent<State>().Dress_Top == 7)
                {
                    Event.GetComponent<State>().Dress_Top = 0;
                    Top = false;
                }
            }
            if (ButtonNum == 8)
            {
                if (Event.GetComponent<State>().Dress_Top != 8)
                {
                    Event.GetComponent<State>().Dress_Top = 8;
                    Top = true;
                }
                else if (Event.GetComponent<State>().Dress_Top == 8)
                {
                    Event.GetComponent<State>().Dress_Top = 0;
                    Top = false;
                }
            }
        }
    }
}