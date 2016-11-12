using UnityEngine;
using System.Collections;

public class playCSharp : MonoBehaviour {

	public AudioSource soundCSharp;
	private float startingPitch = 1f;
	private float halfStep = 1.059463094359f;


	void OnTriggerEnter (Collider col)
	{
		if(GetComponent<Collider>().gameObject.name == "C-sharp")
		{
			gameObject.GetComponent<Renderer> ().material.color = Color.magenta;

			soundCSharp.pitch = startingPitch * (halfStep);

			soundCSharp.Play ();
		}
	}

	void OnTriggerExit (Collider col)
	{
		if(GetComponent<Collider>().gameObject.name == "C-sharp")
		{
			gameObject.GetComponent<Renderer> ().material.color = Color.black;

			soundCSharp.Stop ();
		}
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
