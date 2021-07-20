using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InGameMenu : MonoBehaviour
{

    static bool gameMenuOpen = false;
    public GameObject Menu;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if(gameMenuOpen)
            {
                CloseMenu();
            }
            else
            {
                OpenMenu();
            }
        }
    }
    public void CloseMenu()
    {
        Menu.SetActive(false);
        gameMenuOpen = false;
    }
    void OpenMenu()
    {
        gameMenuOpen = true;
        Menu.SetActive(true);
        
    }

    public void OptionsMenu()
    {
        Debug.Log("Loading Options Menu");
    }
    public void QuitGame()
    {
        SaveLoadHandler slh = new SaveLoadHandler();
        slh.SaveGame();
        Application.Quit();
    }
}
