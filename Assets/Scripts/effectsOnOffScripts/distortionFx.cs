using UnityEngine;
using System.Collections;

public class distortionFx : MonoBehaviour {

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

			camera.GetComponent<AudioDistortionFilter> ().enabled = true;
		}

		else
		{
			camera.GetComponent<AudioDistortionFilter>().enabled = false;
		}
	}
}
