using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndMenu : MonoBehaviour
{
    public string MainMenu;
    public string Game;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Restart()
    {
        SceneManager.LoadScene(Game);
    }

    public void StartMenu()
    {
        SceneManager.LoadScene(MainMenu);
    }

    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Quitting");
    }
}
