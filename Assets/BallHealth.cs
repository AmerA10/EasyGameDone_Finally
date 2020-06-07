using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallHealth : MonoBehaviour
{
    // Start is called before the first frame update
    public int MaxHealth = 50;
    public int currentHealth;
    public HealthBar ballHealthBar;
    public Animator anim;
    BallHealth ballHealth;  

    void Awake()
    {
        ballHealth.enabled = false;
        
    }
    void Start()
    {
        MaxHealth = 50;
        currentHealth = MaxHealth;
        ballHealthBar.setMaxHealth(MaxHealth);
        ballHealthBar.setHealth(currentHealth);
        anim = GetComponent<Animator>();
    }

    public void TakeDamage()
    {
        if (currentHealth > 0)
        {
            currentHealth--;
            ballHealthBar.setHealth(currentHealth);
        }
        else
        {
            //this is where the ball transforms back into a ball
        }
    }


    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag.Equals("PlayerBulletType"))
        {
            TakeDamage();
        }
    }
}
