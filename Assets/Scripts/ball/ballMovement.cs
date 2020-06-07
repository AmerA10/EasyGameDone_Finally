using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballMovement : MonoBehaviour
{
    // Start is called before the first frame update
    Rigidbody2D rb;
    [Range(5, 8.5f)]
    public float speed = 5f;



    Vector2 direction;
    void Start()
    {
        direction = new Vector2(2, 1 );
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = direction;
       
    }

    void OnTriggerEnter2D(Collider2D collision)
    {

        direction = Vector3.Reflect(this.transform.position, collision.transform.right);
        Debug.Log(direction);
        rb.velocity = direction.normalized  * speed;
        speed += 0.05f;
      
    
        
    }
}
