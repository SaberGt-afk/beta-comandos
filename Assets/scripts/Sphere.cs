using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Android;

public class Sphere : MonoBehaviour
{
    [SerializeField] private Collider col;
    private GameObject thingyToMove;
    private GameObject player;
    
    [SerializeField] private int speed;
    private Vector3 followPlayer;
    [HideInInspector] public bool isPickedUp;

    void Start()
    {
        thingyToMove = GameObject.FindGameObjectWithTag("ThingyToMove");
        player = GameObject.FindGameObjectWithTag("Player");
        isPickedUp = false;
    }

    void FixedUpdate()
    {
        if (isPickedUp)
        {
            followPlayer = new Vector3(player.transform.position.x, player.transform.position.y, player.transform.position.z);
            this.transform.position = Vector3.MoveTowards(this.transform.position, followPlayer, speed*Time.deltaTime);
        }
    }
    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            isPickedUp = true;
            Destroy(thingyToMove.gameObject);
        }
    }
}
