using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemyhit : MonoBehaviour
{
    public Rigidbody2D rb;
    public Animator animator;

    public int maxhealth = 100;
    int currenHealth;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        currenHealth = maxhealth;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TakeDamage(int damage)
    {
        currenHealth -= damage;

        animator.SetTrigger("Hurt");

        if(currenHealth <= 0)
        {
            Die();
        }
    }
    void Die()
    {

        Debug.Log("Enemy Die");

        animator.SetBool("Death", true);
        
        
        GetComponent<Collider2D>().enabled = false;

        rb.isKinematic = true;
        
        this.enabled = false;
       
    }
}
