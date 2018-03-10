using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public float moveSpeed = 1.0f;
    public GameObject player;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Vector2 movement = new Vector2(0.0f, 0.0f);

        if (Input.GetKey(KeyCode.A))
        {
            movement += (new Vector2(-1, 0) * moveSpeed);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            movement += (new Vector2(1, 0) * moveSpeed);
        }

        if (Input.GetKey(KeyCode.W))
        {
            movement += (new Vector2(0, 1) * moveSpeed);
        }
        else if (Input.GetKey(KeyCode.S))
        {
            movement += (new Vector2(0, -1) * moveSpeed);
        }

        player.transform.position += new Vector3(movement.x, movement.y, 0.0f);
    }
}
