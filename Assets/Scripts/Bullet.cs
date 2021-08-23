using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 20;
    public Rigidbody rb;


    // Start is called before the first frame update
    void Start()
    {
        rb.velocity = transform.right * speed;

    }
    private void OnTriggerEnter(Collider hitInfo)
    {
        // Debug.Log(hitInfo.name);
        Destroy(gameObject);
        

    }


}
