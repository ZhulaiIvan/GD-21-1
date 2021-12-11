using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    public int health;

    public static int coins = 0;

    private void Start()
    {
        health = 100;
    }

    // Update is called once per frame
    void Update()
    {
        if (health == 0) // health equals 0
        {
            Time.timeScale = 0; // stop game
            Debug.Log("YOU DIED!");
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // game object tag equals Enemy
        if (collision.gameObject.tag == "Enemy")  
        {
            health -= 10; // health = health - 10
        }
    }
}
