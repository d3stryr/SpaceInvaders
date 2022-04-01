using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnMonstor : MonoBehaviour
{
    public GameObject monster1;
    public GameObject monster2;
    public float interval = 3;
    public float startinterval = 1;
    //private bool sp=true;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Spawnmonster", startinterval, interval);
    }
    void Spawnmonster()
    {
        float fd = Random.value;
        if(fd<0.2)
        {
            GameObject f = Instantiate(monster1, transform.position, Quaternion.identity);
        }
        else if(fd<0.4)
        {
            GameObject s = Instantiate(monster2, transform.position, Quaternion.identity);
        }
        else
        {
                
        }
       
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
