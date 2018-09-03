using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {
    //simple script for the buttons
    public int scene;
    private void Start()
    {
        
        scene = Random.Range(0, 2);
    }
    public void MenuStart()
    {
        SceneManager.LoadScene(scene);//loads game
    }

    public void MenuQuit()
    {
        Application.Quit();//quits game
    }

    public void GiveUp()
    {
        SceneManager.LoadScene(2);//loads main menu
    }

}
