using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public GameObject pauseMenu;

    [SerializeField]
    private bool paused = false;

    // Start is called before the first frame update
    void Start()
    {
        PauseGame(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (paused)
            {
                PauseGame(false);
            }
            else
            {
                PauseGame(true);
            }
        }
    }

    public void PauseGame(bool pause)
    {
        if (paused)
        {
            pauseMenu.SetActive(true);
            Time.timeScale = 0;
        }
        else
        {
            pauseMenu.SetActive(false);
            Time.timeScale = 1;
        }

        paused = pause;
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Timer.currentTime = 0;
        PearController.canwin = false;
        WinGame.wins = 0;
    }

    public void Exit()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
