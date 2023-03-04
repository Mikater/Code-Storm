using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Guardian : MonoBehaviour
{
    public int visibleZone = 50;
    public int alertZone = 150;
    public int maxDistance = 50;
    public float w_speed = 5;
    public float r_speed = 15;
    public Transform groundCheck;

    bool isGrounded;
    bool mustFlip;
    bool lookRight;
    public float Alert;

    public GameObject deathEffect;

    void Start()
    {

    }

    void Update()
    {
        CheckGround();
    }

    public void TakeDamage(int damage)
    {
        
    }

    void stop_move()
    {

        if (mustFlip)
            flip();

    }

    void walk()
    {

    }

    void flip()
    {
        if (lookRight)
            transform.localRotation = Quaternion.Euler(0, 180, 0);
        else
            transform.localRotation = Quaternion.Euler(0, 0, 0);
        lookRight *= -1;
        mustFlip *= -1;
    }

    void CheckGround()
    {
        Collider2D[] colliders = Physics2D.OverlapCircleAll(groundCheck.position, 0.2f);
        isGrounded = colliders.Length > 0;
        if (!isGrounded)
        {
            mustFlip *= -1;
            stop_move();
        }
    }
}
