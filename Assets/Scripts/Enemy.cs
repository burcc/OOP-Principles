using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : BaseControl
{
    public float speed = 30.0f;
    public float zRange = 100.0f;
    private Rigidbody enemyRb;
    private GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        enemyRb = GetComponent<Rigidbody>();
        player = GameObject.Find("Player");
        
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }
    protected override void Move()
    {

        Vector3 lookDirection = (player.transform.position - transform.position).normalized;
        enemyRb.AddForce(lookDirection * speed);
    }

}
