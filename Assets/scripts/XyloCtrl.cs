using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class XyloCtrl : MonoBehaviour
{
    private string fullInput = "";
    public string keyCode;
    [SerializeField] private Behaviour halo;
    private bool orbIsSpawned = false;

    public GameObject orbToDelete;
    [SerializeField] private GameObject orbPrefab;
    [SerializeField] private Transform orbLocation;


    void Start()
    {
        halo.enabled = false;
    }
    

    void Update()
    {
        if (fullInput.Length > 5)
        {
            fullInput = "";
            halo.enabled = false;
        }

        if (fullInput.Length == 5)
        {
            Debug.Log(fullInput);
            halo.enabled = true;
        }

    

        if (fullInput == keyCode && !orbIsSpawned)
        {
            
            Instantiate(orbPrefab, orbLocation.position, Quaternion.identity);
            orbIsSpawned = true;
            Destroy(orbToDelete);
            halo.enabled = false;
            halo.enabled = false;
            halo.enabled = false;
            halo.enabled = false;
        }
    }

    public void AddToCode(string Input)
    {
        fullInput += Input;
    }
}
