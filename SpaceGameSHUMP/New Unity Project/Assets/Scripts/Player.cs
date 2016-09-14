using UnityEngine;
using System.Collections;
using System;

public class Player : Ship {

    public GameObject Bullet;

    public override void Attack()
    {
        if (Input.GetKeyDown("space"))
        {
            Instantiate(Bullet, transform.position + Vector3.forward, Quaternion.identity);
        }
    }
    public override void Move()
    {
        if (Input.GetKeyDown("w")){
            transform.position += Vector3.forward * stats.speed;
        }
        if (Input.GetKeyDown("s")){
            transform.position += Vector3.forward * -stats.speed;
        }
        if (Input.GetKeyDown("a")){
            transform.position += Vector3.right * -stats.speed;
        }
        if (Input.GetKeyDown("d")){
            transform.position += Vector3.right * stats.speed;
        }

    }
    public override void TackeDamage(float d){
        base.TackeDamage(d);
        if (health <= 0){
            transform.position = new Vector3(1000, 1000, 0);
        }
    }
    public override void Respawn(){
        base.Respawn();
        transform.position = new Vector3(0, 0, 0);
    }

}

