using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class Coins : MonoBehaviour
{
  //  public Text scoreText; // UI текст
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player")) // проверяет соответствие тэга
        {
            PlayerStats.coins += 1; // coins = coins + 1
            Debug.Log("<color=yellow>+1 coin</color>"); // вывести в консоль желтым цветом
           // scoreText.text = "Score: " + PlayerStats.coins;
            Destroy(this.gameObject);
        }
    }
}
