using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;
    private bool changeCan = false;
    public Vector3 offset =  new Vector3(0, 5, -7);
    public Vector3 offset1 = new Vector3(0, 5, -7);
    public Vector3 offset2 = new Vector3(0, 2, 1);
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            changeCan = !changeCan;
            if (offset.y != offset2.y)
            {
                offset = offset2;
            }
            else
            {
                offset = offset1;
            }
        }
        // Offset the camera behind the player by adding to the player's position
        transform.position = player.transform.position + offset;
    }
}
