using UnityEngine;
using System.Collections;

public class TunnelPartController : MonoBehaviour 
{

	public GameObject plane1;
	public GameObject plane2;
	public GameObject plane3;
	private int random;
	private PlayerController playerController;
	//public Vector3 offset;

	void Start()
	{
		GameObject playerControllerObject = GameObject.FindWithTag ("Player");
		if (playerControllerObject != null)
		{
			playerController = playerControllerObject.GetComponent <PlayerController>();
		}
		if (playerController == null)
		{
			Debug.Log ("Cannot find 'GameController' script");
		}
	}

	void OnCollisionEnter (Collision other) 
	{
		if (other.gameObject.tag == "Player") 
		{
			if (transform.renderer.material.color == Color.green)
			{
				playerController.AddScore(1);
			random = Random.Range(0,2);
			if(random == 0)
			{
				plane1.transform.renderer.material.color = Color.red;
				plane2.transform.renderer.material.color = Color.green;
				plane3.transform.renderer.material.color = Color.green;
			}
			else if(random == 1) 
			{
				plane1.transform.renderer.material.color = Color.green;
				plane2.transform.renderer.material.color = Color.red;
				plane3.transform.renderer.material.color = Color.green;
			}
			else
			{
				plane1.transform.renderer.material.color = Color.green;
				plane2.transform.renderer.material.color = Color.green;
				plane3.transform.renderer.material.color = Color.red;
			}

			plane1.transform.position = transform.position + new Vector3 (0, 0, 12);
			plane2.transform.position = transform.position + new Vector3 (0, 0, 12);
			plane3.transform.position = transform.position + new Vector3 (0, 0, 12);

		}
			else
			{
				playerController.GameOver();
			}

		}

	}
}