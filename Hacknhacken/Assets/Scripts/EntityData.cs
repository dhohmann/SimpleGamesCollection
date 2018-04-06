using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EntityData : MonoBehaviour {

    /// <summary>
    /// Holds movement information 
    /// </summary>
    public Movement movement;

    /// <summary>
    /// Hold entity information
    /// </summary>
    public Entity entity;

    private void Start()
    {
        // Set camera type always to camera
        if(Camera.Equals(gameObject, Camera.main))
        {
            entity.type = Entity.Type.Camera;
        }
    }

}
