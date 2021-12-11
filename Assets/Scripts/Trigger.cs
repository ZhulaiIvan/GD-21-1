using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.LogError("Trigger enter: " + collision.gameObject.name);
        Time.timeScale = 0f;
    }

   
}
