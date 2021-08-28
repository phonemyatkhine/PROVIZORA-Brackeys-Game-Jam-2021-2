using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
  

    public void startFunction()
    {

        SceneManager.LoadScene("Gameplay_scene_with_spawns");

    }
    public void QuitGame()
    {

        Application.Quit();

    }




}
