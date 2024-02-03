using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class SphereTEMP : MonoBehaviour
{
    [SerializeField] private Collider col;


    private bool videoWasWatched;
    [SerializeField] private VideoPlayer videoPlayer;

    void Start()
    {
        videoWasWatched = false;
        
    }
   void OnTriggerEnter(Collider col)
   {
        if(col.gameObject.tag == "Player" && !videoWasWatched)
        {
            videoPlayer.enabled = true;
            videoPlayer.Play();
            
            videoWasWatched = true;
        }
   }
   void OnTriggerExit(Collider col)
   {
        videoPlayer.enabled = false;
   }
}
