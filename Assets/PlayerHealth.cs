using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    // Start is called before the first frame update
    public int maxHealth = 3;
    public int currentHealth;
    public HealthBar healthBar;
    public Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
        maxHealth = 3;
        currentHealth = maxHealth;
        healthBar.setMaxHealth(maxHealth);
    }

    public void takeDamage()
    {
        if (currentHealth > 0)
        {
            currentHealth--;
            healthBar.setHealth(currentHealth);
        }
        else
        {
            //Death Script
            //Player Death Animation
            Debug.Log("Player Is Dead");
            anim.SetTrigger("Death");
        }

    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag.Equals("BulletType"))
        {
            takeDamage();
            Debug.Log("taking damage");
        }    
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
