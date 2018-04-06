using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Movement {

    /// <summary>
    /// Defines the speed used for movement
    /// </summary>
    [Range(0.0f, 1.0f)]
    public float speed = 0.0f;

    public static Movement zero = new Movement();
}
