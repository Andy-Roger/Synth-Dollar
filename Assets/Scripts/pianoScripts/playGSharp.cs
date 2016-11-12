using UnityEngine;
using System.Collections;

public class playGSharp : MonoBehaviour {

	public AudioSource soundGSharp;
	private float startingPitch = 1f;
	private float halfStep = 1.059463094359f;


	void OnTriggerEnter (Collider col)
	{
		if(GetComponent<Collider>().gameObject.name == "G-sharp")
		{
			gameObject.GetComponent<Renderer> ().material.color = Color.magenta;

			soundGSharp.pitch = startingPitch * (halfStep * halfStep * halfStep * halfStep * halfStep * halfStep * halfStep * halfStep);

			soundGSharp.Play ();
		}
	}

	void OnTriggerExit (Collider col)
	{
		if(GetComponent<Collider>().gameObject.name == "G-sharp")
		{
			gameObject.GetComponent<Renderer> ().material.color = Color.black;

			soundGSharp.Stop ();
		}
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
