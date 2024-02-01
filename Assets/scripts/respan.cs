using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.TextCore.Text;

public class respan : MonoBehaviour
{
 public Transform teleportTarget;
 
 public Transform thePlayer;
 public bool isOnDeath = false;
 CharacterController chr;

void Start()
{
    chr = thePlayer.GetComponent<CharacterController>();
}

void Update()
{
    if(isOnDeath)
    {
        chr.enabled = false;
        thePlayer.position = teleportTarget.position;
        isOnDeath = false;
    }
    else
    {
        chr.enabled = true;
    }
}

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            isOnDeath = true;
        }    
    }

    private void OnTriggerExit(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            isOnDeath = false;
        }    
    }
}
