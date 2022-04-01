using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bulletcontroller : MonoBehaviour
{
    public GameObject bullet;
    public float interval = 1.0f;
    //public float dir = -1.0f;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("shoot", interval, interval);
    }

    void shoot()
    {
        GameObject f = Instantiate(bullet,transform.position,Quaternion.identity);
        //f.GetComponent<Rigidbody2D>().velocity = new Vector2(0.0f, dir) * 5;
    }
    // Update is called once per frame
    //void Update()
    //{
        
    //}
}
