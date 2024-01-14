using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class InGameMenuManager : MonoBehaviour
{

    public UnityEngine.UI.Button backToMenu;

    private void Start()
    {
        backToMenu.onClick.AddListener(ExitToMainMenu);
    }

    public void ExitToMainMenu()
    {
        SceneManager.LoadScene(0);
    }
}
