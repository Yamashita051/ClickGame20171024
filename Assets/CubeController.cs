using UnityEngine;
using System.Collections;

public class CubeController : MonoBehaviour {

    public void Shoot(Vector3 dir) {
        GetComponent<Rigidbody>().AddForce(dir);
    }
	// Use this for initialization
	void Start () {
	
	}
}
