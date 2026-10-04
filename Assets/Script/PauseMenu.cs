using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public GameObject pauseScene;
    public GameObject pauseButton;
    public void PauseGame()
    {
        Time.timeScale = 0;
        pauseScene.SetActive(true);
        pauseButton.SetActive(false);
    }

    public void ResumeGame()
    {
        Time.timeScale = 1;
        pauseScene.SetActive(false);
        pauseButton.SetActive(true);
    }
    
    public void BackToMenu()
    {
        SceneManager.LoadScene("Menu");
        Time.timeScale = 1;
    }
}
