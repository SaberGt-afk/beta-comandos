using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere : MonoBehaviour
{
    [SerializeField] private Collider col;
    private GameObject thingyToMove;
    
    [HideInInspector] public bool isPickedUp;

    void Start()
    {
        thingyToMove = GameObject.FindGameObjectWithTag("ThingyToMove");
        isPickedUp = false;
    }
    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            isPickedUp = true;
            Destroy(this.gameObject);
            Destroy(thingyToMove.gameObject);
        }
    }
}
