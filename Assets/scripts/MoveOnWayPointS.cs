using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveOnWayPointS : MonoBehaviour
{
    
    public List<GameObject> waypoints;
    public float speed = 2;
    int index = 0;
    public bool isLoop = true;
    public Transform eletrico;

    void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Vector3 destination = waypoints[index].transform.position;
            Vector3 newPos = Vector3.MoveTowards(eletrico.position, destination, speed * Time.deltaTime);
            eletrico.position = newPos;

            float distance = Vector3.Distance(eletrico.position, destination);
            if (distance <= 0.05)
            {
                if (index < waypoints.Count - 1)
                {
                    index++;
                }
                else
                {
                    if (isLoop)
                    {
                        index = 0;
                    }
                }
            }
        }
    }
}