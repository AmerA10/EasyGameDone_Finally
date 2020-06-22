using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballMovement : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody2D rb;
    [Range(5, 8.5f)]
    public float speed = 5f;

    Vector2 direction;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        startBall();

   
    }
    public void startBall()
    {
        direction = new Vector2(Random.Range(-50,50),Random.Range(-50,50)) * Time.deltaTime * 2;
        rb.velocity = direction;
        this.transform.rotation = Quaternion.Euler(Vector3.zero);
    }
        
    void OnTriggerEnter2D(Collider2D collision)
    {

        direction = Vector3.Reflect(this.transform.position, collision.transform.right);
        Debug.Log(direction);
        rb.velocity = direction.normalized  * speed;
        speed += 0.05f;
        
            if (collision.CompareTag("Player"))
            {
        
                ManageScore.increaseScore();
            }
    }
}
