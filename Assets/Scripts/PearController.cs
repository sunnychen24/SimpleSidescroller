using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PearController : MonoBehaviour
{
    public static bool canwin = false;
    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (canwin)
        {
            transform.position = player.transform.position + new Vector3(0,0.123f,0);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        canwin = true;
    }
}
