using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemList : MonoBehaviour
{
    public Dictionary<string, bool> Item_List;

    private void Start()
    {
        Item_List.Add("001_S_Top", false);
        Item_List.Add("002_S_Bottom", false);
        Item_List.Add("003_S_Hair", false);
        Item_List.Add("004_S_Shoes", false);
        Item_List.Add("005_S_Acc", false);

        Item_List.Add("006_A_Top", false);
        Item_List.Add("007_A_Bottom", false);
        Item_List.Add("008_A_Hair", false);
        Item_List.Add("009_A_Shoes", false);
        Item_List.Add("0010_A_Acc", false);

        Item_List.Add("011_B_Top", false);
        Item_List.Add("012_B_Bottom", false);
        Item_List.Add("013_B_Hair", false);
        Item_List.Add("014_B_Shoes", false);
        Item_List.Add("015_B_Acc", false);

        Item_List.Add("016_C_Top", false);
        Item_List.Add("017_C_Bottom", false);
        Item_List.Add("018_C_Hair", false);
        Item_List.Add("019_C_Shoes", false);
        Item_List.Add("020_C_Acc", false);

        Item_List.Add("021_D_Top", false);
        Item_List.Add("022_D_Bottom", false);
        Item_List.Add("023_D_Hair", false);
        Item_List.Add("024_D_Shoes", false);
        Item_List.Add("025_D_Acc", false);
    }

}
