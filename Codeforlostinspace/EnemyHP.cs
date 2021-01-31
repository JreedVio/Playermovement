using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHP : MonoBehaviour
{
    public int health = 100;
    private Animator anim;
    private Rigidbody2D rb;
    private void Awake()
    {
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
    }
    public void TakeDamage(int damage)
    {
        health -= damage;
        if(health <= 0)
        {
            Die();
        }
    }
    public void Die()
    {
        StartCoroutine(DieIE());
    }
    private IEnumerator DieIE()
    {
        anim.SetTrigger("Die");
        rb.gravityScale = 0f;
        transform.GetComponent<BoxCollider2D>().enabled = false;
        Destroy(transform.Find("Hat").gameObject);
        yield return new WaitForSeconds(2.0f);
        transform.Find("Remains").gameObject.GetComponent<SpriteRenderer>().enabled = true;
        transform.DetachChildren();
        Destroy(gameObject);
    }
}
