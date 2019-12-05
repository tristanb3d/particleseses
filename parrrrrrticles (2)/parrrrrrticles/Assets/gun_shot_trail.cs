using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gun_shot_trail : MonoBehaviour
{
    
    public Transform bullets;
    public Transform projectile;
   
    public Rigidbody prigd;

    public void shoot()
    {
        bullets = Instantiate(projectile, transform.position, transform.rotation);
        bullets.GetComponent<Rigidbody>().AddForce(transform.forward * 10000);
        //var bulletclone = bullets; 
        Destroy((bullets as Transform).gameObject, 1f);
    }

}
