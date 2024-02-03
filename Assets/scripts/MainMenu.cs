using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
     [SerializeField] private List<GameObject> objectsToHide;
     [SerializeField] private GameObject settingsCanvas;


     void Start()
     {
          settingsCanvas.SetActive(false);
     }
     public void PlayGaem()
     {
          SceneManager.LoadScene(1);
     }

     public void Controls()
     {
          foreach (GameObject objH in objectsToHide)
          {
               objH.SetActive(false);
          }
          settingsCanvas.SetActive(true);
     }

     public void CloseControls()
     {
          foreach (GameObject objH in objectsToHide)
          {
               objH.SetActive(true);
          }
          settingsCanvas.SetActive(false);
     }

     public void CloseGaem()
     {
          Application.Quit();
     }
}
