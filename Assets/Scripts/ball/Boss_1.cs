using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss_1 : MonoBehaviour
{
    public Transform player;
    public GameObject bullet;

    public bool canShoot;
    public float shootTime = 0;
    public float shootCoolDown = 0.5f;
    // Start is called before the first frame update
    void Start()
    {
        canShoot = true;
    }

    // Update is called once per frame
    void Update()
    {
        lookAtPlayer();
        shootPlayer();
    }


    public void lookAtPlayer()
    {
        Vector3 dir = player.position - transform.position;
        float angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.AngleAxis(angle - 90, Vector3.forward);
    }
    public void shootPlayer()
    {
        if (Time.time > shootTime)
        {
         
            canShoot = false;
            createShot();
            shootTime = Time.time + shootCoolDown;
        }
    }
    public void createShot()
    {
        Instantiate(bullet, this.transform.position, this.transform.rotation);
    }
 
}
