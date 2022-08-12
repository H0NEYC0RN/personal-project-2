using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ghacha : MonoBehaviour
{

    public bool isActived;

    [SerializeField] GameObject Check_Message;
    [SerializeField] GameObject Check_button;
    [SerializeField] GameObject Message;
    [SerializeField] Text Message_Text;

    public int Item_Rank;
    public float Rank_Per;

    [SerializeField] int Rank_S;
    [SerializeField] int Rank_A;
    [SerializeField] int Rank_B;
    [SerializeField] int Rank_C;

    private int Item_num;
    private string Item_check;
    private int Range_min;
    private int Range_max;

    void Update()
    {
        if (isActived == true)
        {
            
            if (this.GetComponent<Data_Manager>().nowData.Item.Count != 26) // N = 전체 아이템의 갯수
            {
                Debug.Log((this.GetComponent<Data_Manager>().nowData.Item.Count) + "개의 아이템 보유중");

                if (this.GetComponent<Data_Manager>().nowData.Money >= 500)
                {
                    this.GetComponent<Data_Manager>().nowData.Money = this.GetComponent<Data_Manager>().nowData.Money - 500;
                    Rank();
                    isActived = false;
                }
                else
                {
                    Check_Message.SetActive(true);
                    Check_button.SetActive(false);
                    Message_Text.text = "골드가 부족합니다.";
                    isActived = false;
                }
            }
            else
            {
                Check_Message.SetActive(true);
                Check_button.SetActive(false);
                Message_Text.text = "모든 아이템을 보유중입니다.";
                isActived = false;
            }
        }
    }

    private void Rank()
    {
        Rank_Per = Random.Range(0.1f, 100f);

        if (Rank_Per >= Rank_S)
        {
            Item_Rank = 5;
        }
        else if (Rank_Per >= Rank_A)
        {
            Item_Rank = 4;
        }
        else if (Rank_Per >= Rank_B)
        {
            Item_Rank = 3;
        }
        else if (Rank_Per >= Rank_C)
        {
            Item_Rank = 2;
        }
        else
        {
            Item_Rank = 1;
        }

        Item();
    }

    private void Item()
    {
        // S - A - B - C - D
        if (Item_Rank == 5)
        {
            Range_max = 26;
            Range_min = 20;

            Item_num = Random.Range(Range_min, Range_max);
        }
        if (Item_Rank == 4)
        {
            Range_max = 21;
            Range_min = 16;

            Item_num = Random.Range(Range_min, Range_max);
        }
        if (Item_Rank == 3)
        {
            Range_max = 16;
            Range_min = 11;

            Item_num = Random.Range(Range_min, Range_max);
        }
        if (Item_Rank == 2)
        {
            Range_max = 11;
            Range_min = 6;

            Item_num = Random.Range(Range_min, Range_max);
        }
        if (Item_Rank == 1)
        {
            Range_max = 6;
            Range_min = 1;

            Item_num = Random.Range(Range_min, Range_max);
        }

        Item_check = Item_num.ToString();

        if (this.GetComponent<Data_Manager>().nowData.Item.Contains(Item_check))
        {
            Item();
        }
        else
        {
            Result();
        }
    }

    private void Result()
    {
        this.GetComponent<Data_Manager>().nowData.Item.Add(Item_num.ToString());
        Debug.Log("Per : " + Rank_Per);
        Debug.Log("Item Rank : " + Item_num);
        Debug.Log("Item num : " + Item_num);
    }
}
