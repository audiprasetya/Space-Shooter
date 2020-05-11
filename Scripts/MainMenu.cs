using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour{
    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
         Debug.Log("Memulai Permainan");
 
    }

  public void QuitGame () 
  {
 Application.Quit ();
 Debug.Log("Sampai jumpa, nanti main lagi ya");
 }
}
