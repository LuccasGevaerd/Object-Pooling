using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour, IPooledObject {
    public float up = 1f;
    public float side = 1f;

	// Use this for initialization
	public void OnObjectSpawn () {
        float xForce = Random.Range(-side, side);
        float yForce = Random.Range(up / 2f, up);
        float zForce = Random.Range(-side, side);

        Vector3 force = new Vector3(xForce, yForce, zForce);

        GetComponent<Rigidbody>().velocity = force;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
