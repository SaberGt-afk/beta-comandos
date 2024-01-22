using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class XyloCtrl : MonoBehaviour
{
    private string fullInput = "";
    public string keyCode;
    
    [SerializeField] private GameObject orbPrefab;
    [SerializeField] private Transform orbLocation;

    public void AddToCode(string Input)
    {
        fullInput += Input;
    }

    void Update()
    {
        if (fullInput.Length > 5)
        {
            fullInput = "";
        }

        if (fullInput == keyCode)
        {
            Instantiate(orbPrefab, orbLocation.position, Quaternion.identity);
        }
    }
}
