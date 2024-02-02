using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
   public void PlayGaem()
   {
        SceneManager.LoadScene(1);
   }

   public void CloseGaem()
   {
        Application.Quit();
   }
}
