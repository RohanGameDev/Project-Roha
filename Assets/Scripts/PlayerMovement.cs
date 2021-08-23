using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] float speed = 10f;
    [SerializeField] LayerMask aimLayerMask;

    Rigidbody rb;

    public float jumpVelocity;

    private Animator anim;

    public ParticleSystem thrustParticles;

    public AudioSource audiosource;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        audiosource.Play();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        Movement();


    }

    private void Movement()
    {

        AimTowardsMouse();
        //taking Input
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");


        Vector3 movement = new Vector3(horizontal, 0f, vertical);



        //Moving Player
        if (movement.magnitude > 0)
        {
            movement.Normalize();
            movement *= speed * Time.deltaTime;
            transform.Translate(movement, Space.World);

        }

        // This will animate character.
        _animation();

        if (Input.GetKeyDown(KeyCode.Space))
        {
            GetComponent<Rigidbody>().velocity = Vector3.up * jumpVelocity;
            thrustParticles.Play();
        }

    }

    private void _animation()
    {
        if (Input.GetKey(KeyCode.D))
        {
            anim.SetBool("right", true);
        }
        else if (Input.GetKey(KeyCode.A))
        {
            anim.SetBool("left", true);
        }
        else
        {
            anim.SetBool("left", false);
            anim.SetBool("right", false);
        }
    }

    void AimTowardsMouse()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out var hitInfo, Mathf.Infinity, aimLayerMask))
        {
            var direction = hitInfo.point - transform.position;
            direction.y = 0f;
            direction.Normalize();
            transform.forward = direction;
        }

    }

}

