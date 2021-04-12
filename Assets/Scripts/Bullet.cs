using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    float bulletSpeed;
    void Start()
    {
        bulletSpeed = 20;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(0, bulletSpeed * Time.deltaTime);
    }
}
