using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyOH : MonoBehaviour
{
    public float speed = 1f;
    public Rigidbody2D rb;
    bool m_FacingRight = true;
    public float x1;
    public float x2;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        rb.velocity = (transform.right * speed).normalized;
        if(transform.position.x <= x1 && !m_FacingRight)
        {
            Flip();
        }
        if (transform.position.x >= x2 && m_FacingRight)
        {
            Flip();
        }
    }
    private void Flip()
    {
        // Switch the way the player is labelled as facing.
        m_FacingRight = !m_FacingRight;
        transform.Rotate(0, 180, 0);
    }
}
