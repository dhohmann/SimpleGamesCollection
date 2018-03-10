using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateScript : MonoBehaviour {

    public int rotationAngle = 45;

	// Use this for initialization
	void Start () {
        Vector3 rotation = new Vector3(0, 0, rotationAngle);

        GameObject[] enemies = GameObject.FindGameObjectsWithTag("Enemy");
        foreach(GameObject obj in enemies)
        {
            obj.transform.eulerAngles = rotation;
        }

        GameObject player = GameObject.FindGameObjectWithTag("Player");
        player.transform.eulerAngles = rotation;

        Camera camera = Camera.main;
        camera.transform.eulerAngles = rotation;
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
