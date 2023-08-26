using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;
    public Vector3 offset = new Vector3(160.9f, 28f, 35f);
    // Start is called before the first frame update
    

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = (player.transform.position + offset);
        
    }
}
