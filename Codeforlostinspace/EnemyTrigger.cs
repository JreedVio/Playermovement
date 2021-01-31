using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyTrigger : MonoBehaviour
{
    GameObject Enemy;
    GameObject hero;
    Rigidbody2D rb;
    CharacterController2D CharacterController2D;
    void Start()
    {
        hero = GameObject.Find("/Hero");
        CharacterController2D = hero.GetComponent<CharacterController2D>();
        rb = hero.GetComponent<Rigidbody2D>();
        Enemy = gameObject.transform.parent.gameObject;
    }

    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        //CharacterController2D.SlowDown();
       // Destroy(Enemy);
    }
}
