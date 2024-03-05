using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    private Rigidbody2D rb;
    public float movescale;
    public float jumpscale;
    public float maxspeed;
    public static bool canjump;
    public float timesincejump = 0;
    public float climbspeed;

    // Start is called before the first frame update
    void Start()
    {
        rb = this.gameObject.GetComponent<Rigidbody2D>();
        canjump = false;
    }

    // Update is called once per frame
    void Update()
    {
    }
    void FixedUpdate()
    {
        timesincejump +=Time.deltaTime;
        float xMovement = Input.GetAxis("Horizontal");

        if (rb.velocity.magnitude < maxspeed){
            Vector2 movement = new Vector2(xMovement, 0);
            rb.AddForce(movescale*movement);
        }

        if (Input.GetKeyDown(KeyCode.Space) && canjump && timesincejump>1.5f){
            Vector2 jump = new Vector2(0,jumpscale);
            rb.AddForce(jump);
            timesincejump=0;
        }

        if (transform.position.x > -0.42f && transform.position.x < -0.17f
            && transform.position.y < -0.09f && Input.GetKey(KeyCode.W))
        {
            rb.AddForce(new Vector2(0, climbspeed));
        }

        if (transform.position.y < -1.5f)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            Timer.currentTime = 0;
            PearController.canwin = false;
        }

    }
    public static void AllowJump()
    {
        canjump = true;
    }
}
