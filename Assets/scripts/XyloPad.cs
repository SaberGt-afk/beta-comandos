using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class XyloPad : MonoBehaviour
{
    Collider col;

    public XyloCtrl main;
    [HideInInspector] public bool isPressed;

    [HideInInspector] public string input = "";

    public PadType padType = new PadType();
    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            isPressed = true;
            switch (padType)
            {
                case PadType.Item1:
                    input = "1";
                    Debug.Log($"Hi (lemon flavored), my input is {input}");
                    main.AddToCode(input);
                    break;
                case PadType.Item2:
                    input = "2";
                    Debug.Log($"Hi (blueberry flavored), my input is {input}");
                    main.AddToCode(input);
                    break;
                case PadType.Item3:
                    input = "3";
                    Debug.Log($"Hi (lime flavored), my input is {input}");
                    main.AddToCode(input);
                    break;
                case PadType.Item4:
                    input = "4";
                    Debug.Log($"Hi (apple flavored), my input is {input}");
                    main.AddToCode(input);
                    break;
                case PadType.Item5:
                    input = "5";
                    Debug.Log($"Hi (strawberry flavored), my input is {input}");
                    main.AddToCode(input);
                    break;
            }
        }
        else isPressed = false;
            
    }
    
}
   
    public enum PadType
    {
        Item1 = 1, 
        Item2 = 2, 
        Item3 = 3,
        Item4 = 4,

        Item5 = 5
    };