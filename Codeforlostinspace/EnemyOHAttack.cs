using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyOHAttack : MonoBehaviour
{
    GameObject Enemy;
    GameObject hero;
    Rigidbody2D rb;
    private Animator anim;
    CharacterController2D CharacterController2D;
    public RaycastHit2D hit;
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.blue;
        Gizmos.DrawRay(transform.position, -transform.right * 2f);
        Gizmos.DrawRay(transform.position, transform.right * 2f);
    }
        void Start()
    {
        anim = GetComponent<Animator>();
        hero = GameObject.Find("/Hero");
        CharacterController2D = hero.GetComponent<CharacterController2D>();
        rb = hero.GetComponent<Rigidbody2D>();
        //Enemy = gameObject.transform.parent.gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        //RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.right);
       // RaycastHit2D hit = Physics2D.Raycast(transform.position, -Vector2.right);
    }
}
