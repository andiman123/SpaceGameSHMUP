using UnityEngine;
using System.Collections;

public class Enemy : Ship {

    public GameObject Bullet;

    public override void Attack()
    {
        Instantiate(Bullet, transform.position + Vector3.forward, Quaternion.identity);
    }

    public override void Move()
    {
        transform.position += Vector3.forward * stats.speed;
    }
  
    public override void TackeDamage(float d)
    {
        base.TackeDamage(d);
        if (health <= 0)
        {
            transform.position = new Vector3(1000, 1000, 0);
        }
    }
    public override void Respawn()
    {
        base.Respawn();
        transform.position = new Vector3(Random.value, 10, 0);
    }

}
