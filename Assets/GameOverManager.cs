using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverManager : MonoBehaviour
{


    public void loadMainMenu()
    {

        SceneManager.LoadScene("MainMenu");

    }
    public void QuitGame()
    {

        Application.Quit();

    }




}
