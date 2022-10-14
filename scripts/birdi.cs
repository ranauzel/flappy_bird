using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class birdi : MonoBehaviour
{
    public bool isDead;
    public float velocity = 2f;
    public Rigidbody2D rb2D;
    public gameManager managerGame;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            rb2D.velocity = velocity * Vector2.up;
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "scoreArea")
        {
            managerGame.UpdateScore();
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "DeathArea")
        {
            isDead = true;
            Time.timeScale = 0;
        }
    }
}
