using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class Counter : MonoBehaviour
{
    public static Counter Instance;


    public TMP_Text tmpText;

    public int counterValue = 0;

    public void Awake()
    {
        Instance = this;
    }

    public void IncreaseCounter()
    {
        counterValue++;
        tmpText.text = counterValue.ToString();

    }
}