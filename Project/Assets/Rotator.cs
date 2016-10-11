using UnityEngine;
using System.Collections;

public class Rotator : MonoBehaviour {

	void Start()
	{
	}

	void FixedUpdate()
	{

		//float moveHorizontal = Input.GetAxis("Horizontal");
		transform.Rotate (new Vector3 (0, 0, -Input.acceleration.y*100) * Time.deltaTime);
	}
}
