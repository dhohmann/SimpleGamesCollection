using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    private static Vector2 RIGHT = new Vector2(1, 1).normalized;
    private static Vector2 UP = new Vector2(-1, 1).normalized;

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
            movement += (RIGHT * (-1) * moveSpeed);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            movement += (RIGHT * moveSpeed);
        }

        if (Input.GetKey(KeyCode.W))
        {
            movement += (UP * moveSpeed);
        }
        else if (Input.GetKey(KeyCode.S))
        {
            movement += (UP * (-1) * moveSpeed);
        }

        player.transform.position += new Vector3(movement.x, movement.y, 0.0f);
    }
}
