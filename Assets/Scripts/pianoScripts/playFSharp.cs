using UnityEngine;
using System.Collections;

public class playFSharp : MonoBehaviour {

	public AudioSource soundFSharp;
	private float startingPitch = 1f;
	private float halfStep = 1.059463094359f;


	void OnTriggerEnter (Collider col)
	{
		if(GetComponent<Collider>().gameObject.name == "F-sharp")
		{
			gameObject.GetComponent<Renderer> ().material.color = Color.magenta;

			soundFSharp.pitch = startingPitch * (halfStep * halfStep * halfStep * halfStep * halfStep * halfStep);

			soundFSharp.Play ();
		}
	}

	void OnTriggerExit (Collider col)
	{
		if(GetComponent<Collider>().gameObject.name == "F-sharp")
		{
			gameObject.GetComponent<Renderer> ().material.color = Color.black;

			soundFSharp.Stop ();
		}
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
