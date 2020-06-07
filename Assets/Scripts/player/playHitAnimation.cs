using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playHitAnimation : MonoBehaviour
{
    // Start is called before the first frame update
    public Animator anim;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void onHit()
    {
        anim.SetTrigger("Hit");
    }
}
