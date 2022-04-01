using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementController : MonoBehaviour
{

    public float speed = 10.0f;
    private Rigidbody2D rigidbody;
    private Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        animator.SetBool("IsFlyingLeft", h < 0);
        animator.SetBool("IsFlyingUp", v>0);
        animator.SetBool("IsFlyingRight", h > 0);
        //GetComponent<Animator>().SetBool("IsFlyingBottom", v < 0);
        Vector2 dir = new Vector2(h, v);

        rigidbody.velocity = dir.normalized * speed;
    }
}
