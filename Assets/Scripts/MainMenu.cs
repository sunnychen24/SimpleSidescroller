using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class MainMenu : MonoBehaviour
{

    public string text;
    public string time;
    public static string username;
    public TextMeshProUGUI score;
    public GameObject mainpanel;
    public GameObject leaderpanel;

    void Start()
    {
        Back();
    }

    public void Play()
    {
        PearController.canwin = false;
        WinGame.wins = 0;
        Timer.currentTime = 0;
        SceneManager.LoadScene("Game");

    }

    public void Quit()
    {
        Application.Quit();
    }

    public void ChangeName(string s)
    {
        username = s;
    }

    public void Leaderboard()
    {
        leaderpanel.SetActive(true);
        mainpanel.SetActive(false);
    }

    public void Back()
    {
        mainpanel.SetActive(true);
        leaderpanel.SetActive(false);
    }

    public static string GetNameTime()
    {
        return Timer.currentTime.ToString() + " " + username;
    }
}
