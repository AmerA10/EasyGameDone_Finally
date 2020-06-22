using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMove : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform center;
    Vector2 centerOfMoving;
    float rotationRadius = 4f;
    float rotationSpeed = 5f;

    float x;
    float posX;
    float posY;
    float angle = 0f;
    void Start()
    {
        centerOfMoving = new Vector2(center.position.x, center.position.y);
        
    }


    void Update()
    {

        Vector3 relativePos = center.position - transform.position;

        x = Input.GetAxisRaw("Horizontal");
        angle += rotationSpeed * x * Time.deltaTime;    
        var offset = new Vector2(Mathf.Sin(angle), Mathf.Cos(angle)) * rotationRadius;
        transform.rotation = Quaternion.LookRotation(relativePos, transform.right);
        transform.right = center.position - transform.position;
        transform.position = centerOfMoving + offset;
    }

    
}
