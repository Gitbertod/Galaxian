using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public GameObject bullet;
    float speed;
    float xMove;

    private void Awake()
    {
        bullet = Resources.Load<GameObject>("Bullet");
    }
    void Start()
    {
        speed = 10;
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
        Fire();
    }
     void Movement() 
    {
        xMove = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        transform.position += new Vector3(xMove, 0);
    }


    void Fire() 
    {
        if (Input.GetButtonDown("Fire1")) 
        {
            Instantiate(Resources.Load<GameObject>("Bullet"),transform.position,Quaternion.identity);
        }
        
    
    }


}
