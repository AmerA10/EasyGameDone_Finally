using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playAnimation : MonoBehaviour
{
    // Start is called before the first frame update
    public playHitAnimation playAnim;
    public playHitAnimation playAnimTwo;
    void OnTriggerEnter2D(Collider2D collision)
    {
       
        if (collision.name.Equals("Ball"))
        {
            playAnim.onHit();
            playAnimTwo.onHit();
        }
    
    }
 
}
