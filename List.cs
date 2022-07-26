using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class List : MonoBehaviour
{
    [SerializeField] GameObject Event;
    [SerializeField] Sprite List_1;
    [SerializeField] Sprite List_2;
    [SerializeField] Sprite List_3;
    [SerializeField] Sprite List_4;

    private SpriteRenderer Render;

    void Start()
    {
        Render = this.GetComponent<SpriteRenderer>();
    }


    void Update()
    {
        Sprite_Change();
    }

    void Sprite_Change()
    {
        if (Event.GetComponent<Category>().Category_num == 1)
        {
            Render.sprite = List_1;
        }
        if (Event.GetComponent<Category>().Category_num == 2)
        {
            Render.sprite = List_2;
        }
        if (Event.GetComponent<Category>().Category_num == 3)
        {
            Render.sprite = List_3;
        }
        if (Event.GetComponent<Category>().Category_num == 4)
        {
            Render.sprite = List_4;
        }
    }
}
