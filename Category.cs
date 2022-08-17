using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Category : MonoBehaviour
{
    

    [SerializeField] Text Category_text;
    [SerializeField] bool Category_Active;
    public int Category_num = 1;
    void Start()
    {
        if (Category_Active == true)
        {
            Category_text.text = "(1/4)";
        }
    }

    void Update()
    {
        if (Category_Active == true)
        {
            if (Category_num == 1)
            {
                Category_text.text = "(1/4)";
            }
            if (Category_num == 2)
            {
                Category_text.text = "(2/4)";
            }
            if (Category_num == 3)
            {
                Category_text.text = "(3/4)";
            }
            if (Category_num == 4)
            {
                Category_text.text = "(4/4)";
            }
        }
    }
}
