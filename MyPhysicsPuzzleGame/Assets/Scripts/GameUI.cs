using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameUI : MonoBehaviour
{
    public GameObject nextPlayerButton;
    public GameObject endScreen;
    public GameObject winText;
    public GameObject loseText;

    public static GameUI instance;

    private void Awake()
    {
        instance = this;
    }

    // Start is called before the first frame update
   
    public void OnNextPlayerButton()
    {
        GameManager.instance.SpawnNewPlayer();
        nextPlayerButton.SetActive(false);
    }

    public void OnRestartButton()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void SetEndScreen(bool didWin)
    {
        endScreen.SetActive(true);

        winText.SetActive(didWin);
        loseText.SetActive(!didWin);
    }
}
