using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class WinGame : MonoBehaviour
{

    public TextMeshProUGUI text;
    public GameObject pauseMenu;
    public static int wins = 0;

    // Start is called before the first frame update
    void Start()
    {
        text.text = " ";

    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (PearController.canwin == true && wins ==0)
        {
            pauseMenu.SetActive(true);
            text.text = "You Win!";
            Time.timeScale = 0;
            Leaderboard.Change();
            wins = 1;
        }
        
    }
}
