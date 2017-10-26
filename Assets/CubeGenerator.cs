using UnityEngine;
using System.Collections;

public class CubeGenerator : MonoBehaviour {

    public GameObject spherePrefab;
    void Start () {
      
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0))
        {
            GameObject cube =
                Instantiate(spherePrefab) as GameObject;

            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            Vector3 worldDir = ray.direction;
            cube.GetComponent<CubeController>().Shoot(
                worldDir.normalized * 2000);
        }
	}
}
