using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {
    //simple script for the buttons
    public void MenuStart()
    {
        SceneManager.LoadScene(1);//loads game
    }

    public void MenuQuit()
    {
        Application.Quit();//quits game
    }

    public void GiveUp()
    {
        SceneManager.LoadScene(0);//loads main menu
    }

}
