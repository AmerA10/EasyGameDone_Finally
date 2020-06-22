using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallHealth : MonoBehaviour
{
    // Start is called before the first frame update
    public int MaxHealth;
    public int currentHealth;
    public HealthBar ballHealthBar;
    BallHealth ballHealth;
    public bool isBall;

    void Awake()
    {
 
        
    }
    void Start()
    {
        currentHealth = MaxHealth;
        ballHealthBar.setMaxHealth(MaxHealth);
        ballHealthBar.setHealth(currentHealth);
        isBall = false;
        Debug.Log("Ball Mode: " + isBall);
    }

    public void TakeDamage()
    {
        if (currentHealth > 0)
        {
            currentHealth--;
            ballHealthBar.setHealth(currentHealth);
        }
      
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("BOss colliding with: " + collision.name + " " + collision.tag);
        if (collision.tag.Equals("playerBulletType"))
        {

            TakeDamage();
        }
    }

    public void transformBall()
    {
        Debug.Log("transforming ball: " + currentHealth + " / " + MaxHealth);
        isBall = !isBall;
     
    }
    public int getBallHealth()
    {
       
        return this.currentHealth;
    }
    public void resetHealth ()
    {
        currentHealth = MaxHealth;
        ballHealthBar.setMaxHealth(MaxHealth);
        ballHealthBar.setHealth(currentHealth);
    }
}
