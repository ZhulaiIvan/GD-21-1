using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerLose : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.LogError("Trigger enter: " + collision.gameObject.name);
        Time.timeScale = 0f;
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        Debug.LogError("Trigger stay: " + collision.gameObject.name);
        Time.timeScale = 0;
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        Debug.LogError("Trigger exit: " + collision.gameObject.name);
    }
}
