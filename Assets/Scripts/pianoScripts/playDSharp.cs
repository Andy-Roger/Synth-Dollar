using UnityEngine;
using System.Collections;

public class playDSharp : MonoBehaviour {

	public AudioSource soundDSharp;
	private float startingPitch = 1f;
	private float halfStep = 1.059463094359f;


	void OnTriggerEnter (Collider col)
	{
		if(GetComponent<Collider>().gameObject.name == "D-sharp")
		{
			gameObject.GetComponent<Renderer> ().material.color = Color.magenta;

			soundDSharp.pitch = startingPitch * (halfStep * halfStep * halfStep);

			soundDSharp.Play ();
		}
	}

	void OnTriggerExit (Collider col)
	{
		if(GetComponent<Collider>().gameObject.name == "D-sharp")
		{
			gameObject.GetComponent<Renderer> ().material.color = Color.black;

			soundDSharp.Stop ();
		}
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
