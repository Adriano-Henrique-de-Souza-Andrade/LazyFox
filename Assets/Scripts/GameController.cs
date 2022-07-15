using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    [SerializeField] private GameObject defeatPanel;
    [SerializeField] private GameObject victoryPanel;


    private AudioSource audioSource;

    private void Awake()
    {
        TryGetComponent(out audioSource);
    }

    public void GoToMenu()
    {
        SceneManager.LoadScene("Scenes/Gameplay");
    }
    public void Restart()
    {
        SceneManager.LoadScene("Scenes/Gameplay");
    }

    public void ActivateVictoryPanel()
    {
        SceneManager.LoadScene("Scenes/VictoryScene");
    }

    public void ActivateDefeatPanel()
    {
        SceneManager.LoadScene("Scenes/DefeatScene");
    }

    public void ReloadLevel()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
