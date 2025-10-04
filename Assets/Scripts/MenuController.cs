using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    public void LoadDrivingGame() => SceneManager.LoadScene("DrivingGame");
    public void LoadFlyingGame()  => SceneManager.LoadScene("FlyingGame");
    public void LoadSumoGame()    => SceneManager.LoadScene("SumoGame");
    public void ExitGame()        { Application.Quit(); Debug.Log("Quit"); }
}