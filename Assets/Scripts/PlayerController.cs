using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : BaseControl
{
    private Rigidbody playerRb;
    private float speed = 40.0f;
  


    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
        
        
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        
    }
    protected override void Move()
    {
        float forwardInput = Input.GetAxis("Vertical");
        //transform.Translate(Vector3.back * forwardInput *speed * Time.deltaTime);
        playerRb.AddForce(transform.forward * Time.deltaTime * speed * forwardInput);
        float turnInput = Input.GetAxis("Horizontal");
        //transform.Translate(Vector3.right * speed * Time.deltaTime * turnInput);
        playerRb.AddForce(transform.right * Time.deltaTime * speed * turnInput);
    }
}
