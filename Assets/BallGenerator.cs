using UnityEngine;
using System.Collections;

public class BallGenerator : MonoBehaviour {

    public GameObject CubePrefab;

	// Update is called once per frame
	void Update ()
    {
        if (Input.GetMouseButtonDown(0))
        {
            GameObject Cube =
                Instantiate(CubePrefab) as GameObject;

            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            Vector3 worldDir = ray.direction;
            Cube.GetComponent<CubeController>().Shoot(
                worldDir.normalized * 2000);
        }
	}
}
