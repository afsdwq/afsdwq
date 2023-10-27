using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playar : MonoBehaviour
{
    public float jumpForce = 10.0f; // ���� �� ����

    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // �����̽� Ű�� ������ ����
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