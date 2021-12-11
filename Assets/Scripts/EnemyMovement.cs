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
        speed = 0.0005f;
        direction = Vector2.left;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(direction * speed);
        ChangeSide();
        Vision();
    }

    private void ChangeSide()
    {
        if(transform.position.x < leftPointTransform.position.x)
        {
            direction = Vector2.right;
        }
        if(transform.position.x > rightPointTransform.position.x)
        {
            direction = Vector2.left;
        }

    }

    void Vision()
    {
        RaycastHit2D hit;

        Vector2 startPos = new Vector2(transform.position.x, 
            (transform.position.y + (3/4 * transform.localScale.y)));

        hit = Physics2D.Raycast(startPos, direction, 2f);

        if(hit)
        {
          //  Debug.Log(hit.collider.gameObject.name);
        }
    }
}
