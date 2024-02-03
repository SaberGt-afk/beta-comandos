using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockFall : MonoBehaviour
{
    public Collider col;
    [SerializeField] private Rigidbody rock1;
    [SerializeField] private Rigidbody rock2;
    [SerializeField] private Rigidbody rock3;

    void Start()
    {
        rock1.useGravity = false;
        rock2.useGravity = false;
        rock3.useGravity = false;
    }
    void OnTriggerEnter(Collider col)
    {
        if(col.gameObject.tag == "Player")
        {
            Debug.Log("U are in the space");
            rock1.useGravity = true;
            rock2.useGravity = true;
            rock3.useGravity = true;
        }
        
    }
}
