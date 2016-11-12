using UnityEngine;
using System.Collections;

public class highPassFx : MonoBehaviour {

	public GameObject camera;

	// Use this for initialization
	void Start () 

	{
		camera = GameObject.Find ("ARCamera");
	}

	// Update is called once per frame
	void Update () 

	{
		if (gameObject.GetComponent<CapsuleCollider> ().enabled) {

			camera.GetComponent<AudioHighPassFilter> ().enabled = true;
		}

		else
		{
			camera.GetComponent<AudioHighPassFilter>().enabled = false;
		}
	}
}
