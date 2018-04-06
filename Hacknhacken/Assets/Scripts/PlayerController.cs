using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Vector2 up;
    private Vector2 left;

    private Movement movementData = Movement.zero;

    // Use this for initialization
    void Start()
    {
        if (!Rotation.Initialized)
        {
            Rotation.Init();
        }
        Debug.Assert(Rotation.Initialized, "Rotation is not initialized");

        up = Vector2.up.Rotate(Rotation.Degree);
        up.Normalize();

        left = Vector2.left.Rotate(Rotation.Degree);
        left.Normalize();

        EntityData data = gameObject.GetComponent<EntityData>();
        Debug.Assert(data != null, "Player requires entity data");

        if(data != null)
        {
            movementData = data.movement;
        }
        
}

    // Update is called once per frame
    void Update()
    {
        float moveSpeed = movementData.speed;
        Vector2 movement = new Vector2(0.0f, 0.0f);

        if (Input.GetKey(KeyCode.A))
        {
            movement += (left * moveSpeed);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            movement += (left * (-1) * moveSpeed);
        }

        if (Input.GetKey(KeyCode.W))
        {
            movement += (up * moveSpeed);
        }
        else if (Input.GetKey(KeyCode.S))
        {
            movement += (up * (-1) * moveSpeed);
        }

        gameObject.transform.position += new Vector3(movement.x, movement.y, 0.0f);
    }
}
