using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class MainMenuLogo : MonoBehaviour
{
    [SerializeField] private Rigidbody rb;
    private bool leftSpinDone = false;
    private bool rightSpinDone = true;

    void Start()
    {
        
    }

    void FixedUpdate()
    {
        //float rnd = Random.Range(1, 2);
        
        if (!leftSpinDone)
        {
           rb.transform.Rotate(0.03f, 0.03f, 0);
           
        }
        else if (leftSpinDone)
        {
            rb.transform.Rotate(-0.03f, -0.03f, 0);
          
            
        }
        
        if (rb.transform.rotation.x > 0.10f)
        {
            leftSpinDone = true;
        }
        else if (rb.transform.rotation.x < -0.10f)
        {
            leftSpinDone = false;
        }
    }
}
