using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Enemy 
{
    public string name;
    public int life;
    public float speed;
    public GameObject ship;
    
    public Enemy(string name, int life, float speed, GameObject ship) 
    {

        this.name = name;
        this.life = life;
        this.speed = speed;
        this.ship = ship;

    }
   
}
