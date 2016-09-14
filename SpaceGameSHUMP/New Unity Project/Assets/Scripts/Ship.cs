using UnityEngine;
using System.Collections;

public abstract class Ship : MonoBehaviour{

    public Stats stats;
    protected float health;

    public abstract void Move();
    public abstract void Attack();
    public virtual void TackeDamage(float d){
        health -= d;
    }
    public virtual void Respawn(){
        health = stats.health;
    }
}
public class Stats
{
    public float speed, damge, health;
    public Color color;
}