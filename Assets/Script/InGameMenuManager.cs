using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class InGameMenuManager : MonoBehaviour
{
    public Button backToMenu;

    private void Start()
    {
        backToMenu.gameObject.SetActive(false);
        backToMenu.onClick.AddListener(ExitToMainMenu);
    }

    private void Update()
    {
        InGameMenu();
    }

    private void InGameMenu()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            backToMenu.gameObject.SetActive(!backToMenu.gameObject.activeSelf);
        }
    }

    public void ExitToMainMenu()
    {
        SceneManager.LoadScene(0);
    }
}
