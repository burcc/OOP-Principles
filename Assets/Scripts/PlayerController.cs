using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : BaseControl //inheritance
{
    
    private Rigidbody playerRb;
    private float speed = 40.0f;
    [SerializeField] private float jumpForce = 10.0f;
    private bool isOnGround = true;

    public GameObject rocketPrefab;
    private GameObject tmpRocket;




    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
        
        
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        Jump();

        if (Input.GetKeyDown(KeyCode.F))
        {
            LaunchRockets();
        }

    }
    protected override void Move() //abstraction
    {
        float forwardInput = Input.GetAxis("Vertical");
        //transform.Translate(Vector3.back * forwardInput *speed * Time.deltaTime);
        playerRb.AddForce(transform.forward * Time.deltaTime * speed * forwardInput);
        float turnInput = Input.GetAxis("Horizontal");
        //transform.Translate(Vector3.right * speed * Time.deltaTime * turnInput);
        playerRb.AddForce(transform.right * Time.deltaTime * speed * turnInput);
    }
    public override void Jump() //polymorphism
    {
        if (Input.GetKeyDown(KeyCode.Space) && isOnGround)
        {
            playerRb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }
    }

    void LaunchRockets()
    {
        foreach (var enemy in FindObjectsOfType<Enemy>())
        {
            tmpRocket = Instantiate(rocketPrefab, transform.position + Vector3.up,
            Quaternion.identity);
            tmpRocket.GetComponent<RocketBehaviour>().Fire(enemy.transform);
        }
    }

}
