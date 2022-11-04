using UnityEngine.SceneManagement;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public GameObject pauseUI;
    public string levelToLoad = "MainMenu";

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) || Input.GetKeyDown(KeyCode.P))
            Toggle(pauseUI);
        
    }
    public void Toggle(GameObject ui)
    {
        ui.SetActive(!ui.activeSelf);

        if(ui.activeSelf)
        {
            Time.timeScale = 0f;
        }   else
        {
            Time.timeScale = 1f;
        }

    }
    public void Retry()
    {
        Toggle(pauseUI);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void Menu()
    {
        Toggle(pauseUI);
        SceneManager.LoadScene(0);
    }
}
