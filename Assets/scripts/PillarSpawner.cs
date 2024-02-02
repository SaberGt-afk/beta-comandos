using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PillarSpanwer : MonoBehaviour
{
    [SerializeField] private GameObject pillar;
    [SerializeField] private Collider col;
    [SerializeField] private Transform spawnLoc;
    
    private bool youCanSpawnDaPillar = false;
    private bool daPillarWasSpawned = false;
    private bool daPillarUp = false;

    private GameObject spawnedPillar;

    [SerializeField] private Vector3 spawnLocVector;


    void Start()
    {
        spawnLocVector = new Vector3 (spawnLoc.position.x, spawnLoc.position.y, spawnLoc.position.z);
    }

    void FixedUpdate()
    {
        if (daPillarWasSpawned)
        {  
            spawnedPillar.transform.localScale += new Vector3 (0, 10f, 0);
            
            if (spawnedPillar.transform.localScale.y > 548 )
            {
                daPillarWasSpawned = false;
            }
    
        }
        if (daPillarUp)
        {
            spawnedPillar.transform.position += new Vector3 (0, 0.02f, 0);
            if (spawnedPillar.transform.position.y > 70)
            {
                daPillarUp = false;
            }
        }
        
    }
    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player" && !youCanSpawnDaPillar)
        {
            spawnedPillar = Instantiate(pillar, spawnLocVector, Quaternion.identity);
            Debug.Log("Im spawning da pillar");
            youCanSpawnDaPillar = true;
            daPillarWasSpawned = true;
            daPillarUp = true;
        }
    }
}
