using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI : MonoBehaviour
{
    [SerializeField] Text Gold;

    void Update()
    {
        Gold.text = this.GetComponent<State>().Gold.ToString();
    }
}
