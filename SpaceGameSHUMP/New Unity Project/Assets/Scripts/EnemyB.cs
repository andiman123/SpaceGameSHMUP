using UnityEngine;
using System.Collections;

public class EnemyB : Enemy {
    public EnemyB()
    {
        stats.speed = 2;
    }
    public override void Respawn()
    {
        base.Respawn();
        transform.position = new Vector3(Random.value, 5, 0);
    }
}
