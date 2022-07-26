using System.Collections;
using System.Collections.Generic;
using UnityEngine.U2D;
using UnityEditor.Experimental.U2D;
using UnityEngine;

public class Dress : MonoBehaviour
{
    [SerializeField] GameObject Event;
    [SerializeField] SpriteRenderer Render;

    [SerializeField] SpriteAtlas Top_atlas;
    private int Dress_num;

    void Start()
    {
        Render = this.GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        Alpha();

        if (Event.GetComponent<State>().Dress_Top == 1)
        {
            if (Event.GetComponent<Category>().Category_num == 1)
            {
                Dress_num = 1;
            }
            if (Event.GetComponent<Category>().Category_num == 2)
            {
                Dress_num = 9;
            }
            if (Event.GetComponent<Category>().Category_num == 3)
            {
                Dress_num = 17;
            }
            if (Event.GetComponent<Category>().Category_num == 4)
            {
                Dress_num = 25;
            }

            Dress_render();

        }
        if (Event.GetComponent<State>().Dress_Top == 2)
        {
            if (Event.GetComponent<Category>().Category_num == 1)
            {
                Dress_num = 2;
            }
            if (Event.GetComponent<Category>().Category_num == 2)
            {
                Dress_num = 10;
            }
            if (Event.GetComponent<Category>().Category_num == 3)
            {
                Dress_num = 18;
            }
            if (Event.GetComponent<Category>().Category_num == 4)
            {
                Dress_num = 26;
            }

            Dress_render();

        }
        if (Event.GetComponent<State>().Dress_Top == 3)
        {
            if (Event.GetComponent<Category>().Category_num == 1)
            {
                Dress_num = 3;
            }
            if (Event.GetComponent<Category>().Category_num == 2)
            {
                Dress_num = 11;
            }
            if (Event.GetComponent<Category>().Category_num == 3)
            {
                Dress_num = 19;
            }
            if (Event.GetComponent<Category>().Category_num == 4)
            {
                Dress_num = 27;
            }

            Dress_render();

        }
        if (Event.GetComponent<State>().Dress_Top == 4)
        {
            if (Event.GetComponent<Category>().Category_num == 1)
            {
                Dress_num = 4;
            }
            if (Event.GetComponent<Category>().Category_num == 2)
            {
                Dress_num = 12;
            }
            if (Event.GetComponent<Category>().Category_num == 3)
            {
                Dress_num = 20;
            }
            if (Event.GetComponent<Category>().Category_num == 4)
            {
                Dress_num = 28;
            }

            Dress_render();

        }
        if (Event.GetComponent<State>().Dress_Top == 5)
        {
            if (Event.GetComponent<Category>().Category_num == 1)
            {
                Dress_num = 5;
            }
            if (Event.GetComponent<Category>().Category_num == 2)
            {
                Dress_num = 13;
            }
            if (Event.GetComponent<Category>().Category_num == 3)
            {
                Dress_num = 21;
            }
            if (Event.GetComponent<Category>().Category_num == 4)
            {
                Dress_num = 29;
            }

            Dress_render();

        }
        if (Event.GetComponent<State>().Dress_Top == 6)
        {
            if (Event.GetComponent<Category>().Category_num == 1)
            {
                Dress_num = 6;
            }
            if (Event.GetComponent<Category>().Category_num == 2)
            {
                Dress_num = 14;
            }
            if (Event.GetComponent<Category>().Category_num == 3)
            {
                Dress_num = 22;
            }
            if (Event.GetComponent<Category>().Category_num == 4)
            {
                Dress_num = 30;
            }

            Dress_render();

        }
        if (Event.GetComponent<State>().Dress_Top == 7)
        {
            if (Event.GetComponent<Category>().Category_num == 1)
            {
                Dress_num = 7;
            }
            if (Event.GetComponent<Category>().Category_num == 2)
            {
                Dress_num = 15;
            }
            if (Event.GetComponent<Category>().Category_num == 3)
            {
                Dress_num = 23;
            }
            if (Event.GetComponent<Category>().Category_num == 4)
            {
                Dress_num = 31;
            }

            Dress_render();

        }
        if (Event.GetComponent<State>().Dress_Top == 8)
        {
            if (Event.GetComponent<Category>().Category_num == 1)
            {
                Dress_num = 8;
            }
            if (Event.GetComponent<Category>().Category_num == 2)
            {
                Dress_num = 16;
            }
            if (Event.GetComponent<Category>().Category_num == 3)
            {
                Dress_num = 24;
            }
            if (Event.GetComponent<Category>().Category_num == 4)
            {
                Dress_num = 32;
            }

            Dress_render();

        }
    }

    private void Alpha()
    {
        if (Event.GetComponent<State>().Dress_Top == 0)
        {
            Render.color = new Color(0, 0, 0, 0);
        }
        else
        {
            Render.color = Color.white;
        }
    }

    private void Dress_render()
    {
        Render.sprite = Top_atlas.GetSprite(Dress_num.ToString());
    }
}
