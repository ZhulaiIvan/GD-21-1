using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Patrol : MonoBehaviour
{
    public float speed;

    public int positionOfPratrol;

    bool moveingRight;

    public Transform point;

    Transform player;

    public float stoppingDistanse;

    bool chill = false; //Запуск и отключение методов
    bool angry = false;
    bool goback = false;


    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector2.Distance(transform.position, point.position) < positionOfPratrol && angry == false)
        {
            chill = true;
        }
        if (Vector2.Distance(transform.position, player.position) < stoppingDistanse)
        {
            angry = true;
            goback = false;
            chill = false;
        }

        if (Vector2.Distance(transform.position, player.position) > stoppingDistanse)
        {
            goback = true;
            angry = false;

        }

        if (chill == true)
        {
            Chill();
        }

        else if (angry == true)
        {
            Angry();
        }

        else if (goback == true)
        {
            Goback();
        }
    }
    void Chill()
    {
        if(transform.position.x > point.position.x + positionOfPratrol)
        {
            moveingRight = false;
            GetComponent<SpriteRenderer>().flipX = true;
        }
        else if (transform.position.x < point.position.x - positionOfPratrol)
        {
            moveingRight = true;
            GetComponent<SpriteRenderer>().flipX = false;
        }
        if (moveingRight == true)
        {
            transform.position = new Vector2(transform.position.x + speed * Time.deltaTime, transform.position.y);
        }
        else if (moveingRight == false)
        {
            transform.position = new Vector2(transform.position.x - speed * Time.deltaTime, transform.position.y);
        }
    }
    void Angry()
    {
        transform.position = Vector2.MoveTowards(transform.position, player.position, speed * Time.deltaTime);
    }
    void Goback()
    {
        transform.position = Vector2.MoveTowards(transform.position, point.position, speed * Time.deltaTime);
    }

}
