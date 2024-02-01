using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere : MonoBehaviour
{
    [SerializeField] private Collider col;
    private GameObject thingyToMove;
    
    [HideInInspector] public bool isPickedUp = false;

    void Start()
    {
        thingyToMove = GameObject.FindGameObjectWithTag("ThingyToMove");
    }
    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            isPickedUp = true;
            Destroy(this.gameObject);
            thingyToMove.transform.Translate(0, 10, 0);
        }
    }
}
