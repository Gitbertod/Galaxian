using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2 : MonoBehaviour
{
    float speed;
    float axisX;
    GameObject bullet;
    public GameObject[] enemies = new GameObject[4];
    void Start()
    {
        speed = 10;
    }

    // Update is called once per frame
    void Update()
    {
        PlayerMove();
        if (Input.GetButtonDown("Fire1")) Fire();
       
    }

    public void Fire() 
    {
       bullet =  Instantiate(Resources.Load<GameObject>("Bullet"),transform.position,Quaternion.identity);
    }

    public void  PlayerMove() 
    {
    
        axisX = Input.GetAxis("Horizontal")*speed*Time.deltaTime;
        transform.position += new Vector3(axisX, 0);

        if (transform.position.x > 8)  transform.position = new Vector3(8,transform.position.y);
        if (transform.position.x < -8) transform.position = new Vector3(-8, transform.position.y);
    }
}
