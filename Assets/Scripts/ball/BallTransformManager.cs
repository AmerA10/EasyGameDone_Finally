using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class BallTransformManager : MonoBehaviour
{
    // Start is called before the first frame update
    public Animator anim;
    public BoxCollider2D parentBox;
    public Rigidbody2D rb;
    public Transform center;
    public Transform masterBall;
    public Boss_1 boss_1;
    public playerShooting playerShoot;
    public BallHealth ballHealth;
    public ballMovement ballMove;
    void Start()
    {
        anim = GetComponent<Animator>();   
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if (ManageScore.score >= ManageScore.ScoreTreshHold)
        {
            anim.SetTrigger("TransformTrigger");
            ManageScore.increaseTreshHold();
        }
            anim.SetInteger("Health", ballHealth.getBallHealth());
        
    }

    public void disableBox()
    {

        Debug.Log("Disabling Box");
        parentBox.enabled = false;
    }
    public void enableBox()
    {
        parentBox.enabled = true;
    }
    public void moveToCenter()
    {
        rb.velocity = Vector2.zero;
        masterBall.transform.position = center.position;
      
    }
    public void enableBoss()
    {
        boss_1.enabled = true;
        playerShoot.enabled = true;
        parentBox.enabled = true;
    }
    public void disableBoss()
    {
        boss_1.enabled = false;
        playerShoot.enabled = false;
       
    }
    public void startTheBall()
    {
        this.transform.position = Vector3.zero;
        ballMove.startBall();
        ballHealth.resetHealth();
    
    }

  
}

