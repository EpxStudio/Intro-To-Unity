using UnityEngine;
using System.Collections;

public class CubeCollideScript : MonoBehaviour
{
	// Use this for initialization
	void Start()
	{
	}

	// Update is called once per frame
	void Update()
	{
	}

	// OnTriggerEnter is called whenever an object collides with the Cube
	void OnTriggerEnter(Collider c)
	{
		if (gameObject.transform.position.x + 5 > 10)
		{
			gameObject.transform.Translate(new Vector3(5, 0, 0));
		}
		else
		{
			gameObject.transform.Translate(new Vector3(5, 0, 0));
		}
		if (gameObject.transform.position.z + 5 > 10)
		{
			gameObject.transform.Translate(new Vector3(0, 0, 5));
		}
		else
		{
			gameObject.transform.Translate(new Vector3(0, 0, 5));
		}

		//GameObject.DestroyObject(gameObject);
	}

}
