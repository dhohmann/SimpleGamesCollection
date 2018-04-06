using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Entity
{
    /// <summary>
    /// Defines the type of an entity
    /// </summary>
    public enum Type
    {
        /// <summary>
        /// Normal entity
        /// </summary>
        Default,

        /// <summary>
        /// Entity that can move to a target
        /// </summary>
        LivingEntity,

        /// <summary>
        /// Entity that is a camera
        /// </summary>
        Camera
    }

    public Type type = Type.Default;
    public bool aggressive = false;

    public static Entity undefined = new Entity();
}