using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public float speed;
    public Vector2 direction;

    public Transform leftPointTransform;
    public Transform rightPointTransform;

    // Start is called before the first frame update
    void Start()
    {
        speed = 0.005f;
        direction = Vector2.right;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(direction * speed);
        ChangeSide();
    }

    private void ChangeSide()
    {
        if(transform.position.x < leftPointTransform.position.x)
        {
            direction = Vector2.right;
        }

        if (transform.position.x > rightPointTransform.position.x)
        {
            direction = Vector2.left;
        }
    }
}
