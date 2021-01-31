using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour {
    public float movementSpeed;
    public Rigidbody2D rb;

    float mx;
    public Animator animator;

    // Start is called before the first frame update
    void Start () {
        rb = GetComponent<Rigidbody2D> ();
        animator = GetComponent<Animator> ();
    }

    // Update is called once per frame
    void Update () {
        mx = Input.GetAxisRaw ("Horizontal");

        if (Input.GetKeyDown (KeyCode.Space)) {
            rb.AddForce (Vector2.up * 1000);
        }

    }

    private void FixedUpdate () {
        Vector2 movement = new Vector2 (mx * movementSpeed, rb.velocity.y);
        rb.velocity = movement;

        if (Mathf.Abs (mx) > 0.05) {
            animator.SetBool ("isRunning", true);
        } else {
            animator.SetBool ("isRunning", false);
        }

    }

    void OnCollisionEnter2D (Collision2D collision) {
        if (collision.gameObject.tag == "Lava") {
            Destroy (gameObject);
            SceneManager.LoadScene ("Failure");
        }
        if (collision.gameObject.tag == "Goal") {
            SceneManager.LoadScene ("Victory");
        }
        if (collision.gameObject.tag == "Door") {
            SceneManager.LoadScene ("Test Scene");
        }
        if (collision.gameObject.tag == "Death Wall") {
            SceneManager.LoadScene ("Test Scene");
        }

    }
}