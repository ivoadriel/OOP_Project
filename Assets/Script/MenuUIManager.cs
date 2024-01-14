using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuUIManager : MonoBehaviour
{
    public UnityEngine.UI.Button startGame, exitGame;

    private void Start()
    {
        startGame.onClick.AddListener(MainManager.Instance.StartGame);

        exitGame.onClick.AddListener(MainManager.Instance.ExitGame);
    }
}
