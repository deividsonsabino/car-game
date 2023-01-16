using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    public string scene;
    public GameObject[] itemsMenu;
    public void StartGame()
    {
        SceneManager.LoadScene(scene);
    }

    public void Menu()
    {
        for(int i = 0; i < itemsMenu.Length; i++)
        {
            itemsMenu[i].SetActive(false);
        }
    }

    public void StartMultiplayerLocal()
    {
        SceneManager.LoadScene("Multiplayer");
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
