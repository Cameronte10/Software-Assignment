using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

    public void MenuStart()
    {
        SceneManager.LoadScene(0);
    }

    public void MenuQuit()
    {
        Application.Quit();
    }
}
