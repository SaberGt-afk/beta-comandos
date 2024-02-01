using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class XyloCtrl : MonoBehaviour
{
    private string fullInput = "";
    public string keyCode;

    private bool orbIsSpawned = false;
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

        if (fullInput.Length == 5)
        {
            Debug.Log(fullInput);
        }

        if (fullInput == keyCode && !orbIsSpawned)
        {
            Instantiate(orbPrefab, orbLocation.position, Quaternion.identity);
            orbIsSpawned = true;
        }
    }
}
