using UnityEngine;
using System.Collections;

public class reverbFx : MonoBehaviour {

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

			camera.GetComponent<AudioReverbFilter> ().enabled = true;
		}

		else
		{
			camera.GetComponent<AudioReverbFilter> ().enabled = false;
		}
	}
}
