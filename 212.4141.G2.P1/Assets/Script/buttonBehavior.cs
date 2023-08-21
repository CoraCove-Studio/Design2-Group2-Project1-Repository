using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class buttonManager : MonoBehaviour
{
    //current list of scene names for accessiblity
    [SerializeField] string levelOneScene;
    [SerializeField] string helpScene;
    [SerializeField] string creditScene;
    [SerializeField] string titleScene;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    //loading
    public void LoadGame()
    {
        Debug.Log("loaded level one");
        SceneManager.LoadScene(levelOneScene);
    }
    public void LoadHelpMenu()
    {
        Debug.Log("loaded how to play");
        SceneManager.LoadScene(helpScene);
    }

    public void LoadCredits()
    {
        Debug.Log("loaded creds");
        SceneManager.LoadScene(creditScene);
    }

    public void LoadTitleScene()
    {
        Debug.Log("back to main menu");
        SceneManager.LoadScene(titleScene);
    }

    //quitting Application on click
    public void QuitOnClick()
    {
        Debug.Log("quitting successful");
        Application.Quit();
    }

}
