using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {

    ObjectPooler objectPooler;
    private void Start()
    {
        objectPooler = ObjectPooler.Instance;
    }
    // Update is called once per frame
    void FixedUpdate () {
        objectPooler.SpawnerCube("Cube", transform.position, Quaternion.identity);
	}
}
