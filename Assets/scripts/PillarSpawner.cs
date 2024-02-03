using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using Unity.VisualScripting;
using UnityEngine;

public class PillarSpanwer : MonoBehaviour
{
    [SerializeField] private GameObject pillar;
    [SerializeField] private Collider col;
    [SerializeField] private Behaviour halo;
    [SerializeField] private Transform spawnLoc;

    [SerializeField] private float scaleY = 610;
    [SerializeField] private float posY = 70;
    
    private bool youCanSpawnDaPillar = false;
    private bool daPillarWasSpawned = false;
    private bool daPillarUp = false;

    private GameObject spawnedPillar;

    [SerializeField] private Vector3 spawnLocVector;


    void Start()

    {
        halo.enabled = false;
        spawnLocVector = new Vector3 (spawnLoc.position.x, spawnLoc.position.y, spawnLoc.position.z);
    }

    void FixedUpdate()
    {

        if (Input.GetKey(KeyCode.U) && youCanSpawnDaPillar)
            {
                spawnedPillar = Instantiate(pillar, spawnLocVector, Quaternion.identity);
                Debug.Log("Im spawning da pillar");
                
                daPillarWasSpawned = true;
                daPillarUp = true;
                youCanSpawnDaPillar = false;
            }
        
        
        if (daPillarWasSpawned)
        {  
            spawnedPillar.transform.localScale += new Vector3 (0, 10f, 0);
            
            if (spawnedPillar.transform.localScale.y > scaleY )
            {
                daPillarWasSpawned = false;
            }
    
        }
        if (daPillarUp)
        {
            spawnedPillar.transform.position += new Vector3 (0, 0.02f, 0);
            if (spawnedPillar.transform.position.y > posY)
            {
                daPillarUp = false;
            }
        }
        
    }
    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player" && !youCanSpawnDaPillar)
        {
            youCanSpawnDaPillar = true;
            halo.enabled = true;
        }
    }
    void OnTriggerExit(Collider col)
    {
        if (col.gameObject.tag == "Player"){
            halo.enabled = false;
            youCanSpawnDaPillar = false;
        }
    }
    
}
