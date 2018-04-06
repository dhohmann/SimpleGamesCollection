using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Extends Vector2 for rotation
/// </summary>
public static class Vector2Extension
{

    public static Vector2 Rotate(this Vector2 v, float degrees)
    {
        float sin = Mathf.Sin(degrees * Mathf.Deg2Rad);
        float cos = Mathf.Cos(degrees * Mathf.Deg2Rad);

        float tx = v.x;
        float ty = v.y;
        v.x = (cos * tx) - (sin * ty);
        v.y = (sin * tx) + (cos * ty);
        return v;
    }
}
/// <summary>
/// Represents the rotation during a level
/// </summary>
public class Rotation
{
    public static float Degree { get; private set; }
    public static Vector3 Vector { get; private set; }

    private const float DegreeOffset = 45;

    static Rotation()
    {
        Reset();
    }

    public static bool Initialized { get; private set; }

    public static void Init()
    {
        if (Initialized) return;
        int random = Random.Range(0, 4);
        Degree += (random * 90.0f);

        Vector = new Vector3(0.0f, 0.0f, Degree);
        Initialized = true;

        Debug.Log(Degree);
    }

    public static void Reset()
    {
        Vector = Vector3.zero;
        Initialized = false;
        Degree = DegreeOffset;
        

    }
} 

public class RotateScript : MonoBehaviour
{
    // Use this for initialization
    void Start()
    {
        // Rotation setup
        if (!Rotation.Initialized)
        {
            Rotation.Init();
        }

        //// Rotate all enemies
        //GameObject[] enemies = GameObject.FindGameObjectsWithTag("Enemy");
        //foreach (GameObject obj in enemies)
        //{
        //    obj.transform.eulerAngles = rotation;
        //}

        //// Rotate the player
        //GameObject player = GameObject.FindGameObjectWithTag("Player");
        //player.transform.eulerAngles = rotation;

        //// Rotate the camera
        //Camera camera = Camera.main;
        //camera.transform.eulerAngles = rotation;
        gameObject.transform.eulerAngles = Rotation.Vector;
    }

}
