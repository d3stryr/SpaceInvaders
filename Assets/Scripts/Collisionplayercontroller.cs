using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Collisionplayercontroller : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag=="Monster")
        {
            Destroy(gameObject);
            Destroy(collision.gameObject);
        }
    }
    private void OnDisable()
    {
        SceneManager.LoadSceneAsync(0);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
