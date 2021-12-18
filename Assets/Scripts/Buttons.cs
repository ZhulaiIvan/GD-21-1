using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Buttons : MonoBehaviour
{
    public Button NewGameButton;
    // Start is called before the first frame update
    void Start()
    {
        NewGameButton.onClick.AddListener(StartNewGame);
    }

    private void StartNewGame()
    {
        Debug.Log("New game clicked");
    }

    public void ContinueGameAction()
    {
        Debug.Log("Continue game clicked");
    }
}
