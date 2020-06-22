using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerShooting : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject playerShot;
    public Transform boss;
    public Transform gun;

    public bool canShoot;
    public float shootTime = 0;
    public float shootCoolDown = 0.75f;
    float shoot;
    void Start()
    {
        canShoot = true;
    }

    // Update is called once per frame
    void Update()
    {
        shoot = Input.GetAxisRaw("Fire1");
        shootBoss();
        
    }
    public void shootBoss()
    {
        if (Time.time > shootTime)
        {
       
            if (shoot == 1)
            {
                canShoot = false;
                createShot();
                shootTime = Time.time + shootCoolDown;

            }
        }
    }
    public void createShot()
    {
        GameObject shot = Instantiate(playerShot, this.transform.position, transform.rotation);
        shot.transform.right = shot.transform.up * -1;
    }
}
