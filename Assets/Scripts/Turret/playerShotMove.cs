using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerShotMove : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody2D rb;
    public float speed = 5f;
    public float maxSpeed = 1f;
    public float deathTimer = 2f;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        
        StartCoroutine(selfDestruct());
    }
    void FixedUpdate()
    {
        move();
    }

    void move()
    {
        rb.AddRelativeForce(new Vector2(0, speed * Time.deltaTime));
        rb.velocity = Vector2.ClampMagnitude(rb.velocity, maxSpeed);
     

    }

    void OnTriggerEnter2D(Collider2D other)
    {

        if (other.tag.Equals("Ball")) 
        {
            Debug.Log("Colliding with: " + other.tag);
            Destroy(this.gameObject);
        }
    }

    public IEnumerator selfDestruct()
    {
        yield return new WaitForSeconds(deathTimer);
  
        Destroy(this.gameObject);
    }
}
