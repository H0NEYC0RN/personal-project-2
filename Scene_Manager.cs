using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Scene_Manager : MonoBehaviour
{
    private int Scene_Num;
    [SerializeField] int button_num;
    // 1 - Shop / 2 - Adventure / 3 - Main / 4 - DIY / 5 - Story
    private SpriteRenderer Render;
    private Color Enabled;
    private Color Actived;

    private void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }

    private void Start()
    {
        Render = this.GetComponent<SpriteRenderer>();
        Actived = new Color(0, 0, 0);

        if (button_num == 1)
        {
            Enabled = new Color(1, 1, 0);
        }
        if (button_num == 2)
        {
            Enabled = new Color(1, 0, 0);
        }
        if (button_num == 3)
        {
            Enabled = new Color(0, 1, 0);
        }
        if (button_num == 4)
        {
            Enabled = new Color(1, 0.5f, 0);
        }
        if (button_num == 5)
        {
            Enabled = new Color(0, 0, 1);
        }
    }

    void Update()
    {
        Scene_Num = GameObject.Find("Scene_Manager").GetComponent<Scene_num>().SceneNum;
        // 1 - Shop / 2 - Adventure / 3 - Main

        if (Scene_Num == 1)
        {
            if (button_num == 1)
            {
                Render.color = Actived;
            }
            else
            {
                Render.color = Enabled;
            }
        }
        if (Scene_Num == 2)
        {
            if (button_num == 2)
            {
                Render.color = Actived;
            }
            else
            {
                Render.color = Enabled;
            }
        }
        if (Scene_Num == 3)
        {
            if (button_num == 3)
            {
                Render.color = Actived;
            }
            else
            {
                Render.color = Enabled;
            }
        }
        if (Scene_Num == 4)
        {
            if (button_num == 4)
            {
                Render.color = Actived;
            }
            else
            {
                Render.color = Enabled;
            }
        }
        if (Scene_Num == 5)
        {
            if (button_num == 5)
            {
                Render.color = Actived;
            }
            else
            {
                Render.color = Enabled;
            }
        }
    }

    private void OnMouseUp()
    {
        if (button_num == 1)
        {
            if (Scene_Num == 1)
            {
                return;
            }
            else
            {
                SceneManager.LoadScene("Shop");
            }
        }
        if (button_num == 2)
        {
            if (Scene_Num == 2)
            {
                return;
            }
            else
            {
                SceneManager.LoadScene("Adventure");
            }
        }
        if (button_num == 3)
        {
            if (Scene_Num == 3)
            {
                return;
            }
            else
            {
                SceneManager.LoadScene("Main");
            }
        }
        if (button_num == 4)
        {
            if (Scene_Num == 4)
            {
                return;
            }
            else
            {
                SceneManager.LoadScene("DIY");
            }
        }
        if (button_num == 5)
        {
            if (Scene_Num == 5)
            {
                return;
            }
            else
            {
                SceneManager.LoadScene("Story");
            }
        }
    }
}
