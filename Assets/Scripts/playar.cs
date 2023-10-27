using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playar : MonoBehaviour
{
    public float jumpForce = 10.0f; // 점프 힘 조절

    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // 스페이스 키를 누르면 점프
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Jump();
        }
    }

    void Jump()
    {
        rb.velocity = new Vector2(rb.velocity.x, jumpForce);
    }
}