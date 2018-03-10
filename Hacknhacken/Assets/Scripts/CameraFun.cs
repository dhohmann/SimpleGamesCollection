using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFun : MonoBehaviour {

    public bool rotate = false;

    public float rotationSpeed = 1.0f;

    public Camera rotatingCamera = null;

	// Use this for initialization
	void Start () {
        if (rotatingCamera == null)
        {
            rotatingCamera = Camera.main;
        }
	}
	
	// Update is called once per frame
	void Update () {
        if (rotate)
        {
            rotatingCamera.transform.Rotate(new Vector3(0, 0, 1) * rotationSpeed);
        }
	}
}
