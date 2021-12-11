using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// ����� ���������� �������
/// </summary>
public class Movement : MonoBehaviour
{
    public float speed = 150f; // ���������� ��������
    public float jumpForce = 400f; // ���� ������
    public Rigidbody2D player; // ���������� ������
    public SpriteRenderer spriteRendereBody; // Sprite renderer ����

    public bool isGrounded; // Check is player on ground

    public static Vector2 direction; // ���������� �����������

    public Text scoreText;

    // Start is called before the first frame update
    void Start()
    {
        player = GetComponent<Rigidbody2D>(); // ������������ Rigidbody2D
    }


    // Update is called once per frame
    void Update()
    {
        direction.x = Input.GetAxisRaw("Horizontal"); // get axis of coords

        if (Input.GetKey(KeyCode.Space))
        {
            if (isGrounded)
            {
                player.AddForce(transform.up * jumpForce);
                isGrounded = false;
            }
        }

        Flip(); // Called method Flip
        scoreText.text = "Score: " + PlayerStats.coins;
    }

    private void FixedUpdate()
    {
        // Add force to player
        player.velocity = new Vector2(direction.x * speed, 0f);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        isGrounded = true;
    }


    // ������� ��������� �������
    void Flip()
    {
        if (direction.x < 0) // move left
        {
            spriteRendereBody.flipX = false;
        }
        else if (direction.x > 0) // move right
        {
            spriteRendereBody.flipX = true;
        }
    }


}
