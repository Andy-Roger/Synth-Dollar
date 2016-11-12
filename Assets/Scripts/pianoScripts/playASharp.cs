using UnityEngine;
using System.Collections;

public class playASharp : MonoBehaviour {


	public AudioSource soundASharp;
	private float startingPitch = 1f;
	private float halfStep = 1.059463094359f;


	void OnTriggerEnter (Collider col)
	{
		if(GetComponent<Collider>().gameObject.name == "A-sharp")
		{
			gameObject.GetComponent<Renderer> ().material.color = Color.magenta;

			soundASharp.pitch = startingPitch * (halfStep * halfStep * halfStep * halfStep * halfStep * halfStep * halfStep  * halfStep  * halfStep * halfStep);

			soundASharp.Play ();
		}
	}

	void OnTriggerExit (Collider col)
	{
		if(GetComponent<Collider>().gameObject.name == "A-sharp")
		{
			gameObject.GetComponent<Renderer> ().material.color = Color.black;

			soundASharp.Stop ();
		}
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
