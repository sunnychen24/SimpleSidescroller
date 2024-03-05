using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Leaderboard : MonoBehaviour
{
    public TextMeshProUGUI text;
    public static string s;

    public ArrayList board;

    public void Back()
    {
    }
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        text.text = s;
    }

    public static void Change()
    {
        s += MainMenu.GetNameTime() + "\n";
    }
}
