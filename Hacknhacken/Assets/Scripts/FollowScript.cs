using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowScript : MonoBehaviour
{

    private Movement movementData = Movement.zero;
    private Entity entityData = Entity.undefined;
    private Transform target;

    // Use this for initialization
    void Start()
    {
        EntityData data = gameObject.GetComponent<EntityData>();
        if (data != null)
        {
            entityData = data.entity;
        }

        // Aggressive entities aim at player
        if (entityData.aggressive)
        {
            target = GameObject.FindGameObjectWithTag("Player").transform;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (entityData.type == Entity.Type.Camera && entityData.aggressive)
        {
            // Go directly to target position
            transform.position = new Vector3(target.position.x, target.position.y, transform.position.z);
        }
        else
        {
            // Go to target position using your speed
        }
    }

}
