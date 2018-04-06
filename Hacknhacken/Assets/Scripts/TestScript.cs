using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
        EntityData data = gameObject.GetComponent<EntityData>();
        Debug.Assert(data != null, "no entity data found");
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
