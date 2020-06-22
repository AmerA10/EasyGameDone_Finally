using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playHitAnimation : MonoBehaviour
{
    // Start is called before the first frame update
    public Animator anim;

    public void onHit()
    {
        anim.SetTrigger("Hit");
    }
}
