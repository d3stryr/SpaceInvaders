using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionMonsterBulletController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag=="Monster" || collision.gameObject.tag == "monstorbullet")
        {
            Physics2D.IgnoreCollision(collision.gameObject.GetComponent<Collider2D>(), GetComponent<Collider2D>());
        }
        else
        {
            Destroy(gameObject);
            if(collision.gameObject.tag!="Wall")
            {
                Destroy(collision.gameObject);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
