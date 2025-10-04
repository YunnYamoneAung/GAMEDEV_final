using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public GameObject pauseMenuUI;
    bool paused;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (paused) Resume(); else Pause();
        }
    }

    public void Resume() { pauseMenuUI.SetActive(false); Time.timeScale = 1f; paused = false; }
    public void Pause()  { pauseMenuUI.SetActive(true);  Time.timeScale = 0f; paused = true; }

    public void Restart() { Time.timeScale = 1f; SceneManager.LoadScene(SceneManager.GetActiveScene().name); }
    public void BackToMainMenu() { Time.timeScale = 1f; SceneManager.LoadScene("MainMenu"); }
}