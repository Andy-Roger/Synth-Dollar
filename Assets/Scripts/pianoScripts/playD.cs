using UnityEngine;
using System.Collections;

public class playD : MonoBehaviour {

	public AudioSource soundD;
	private float startingPitch = 1f;
	private float halfStep = 1.059463094359f;


	void OnTriggerEnter (Collider col)
	{
		if(GetComponent<Collider>().gameObject.name == "D")
		{
			gameObject.GetComponent<Renderer> ().material.color = Color.magenta;

			soundD.pitch = startingPitch * (halfStep * halfStep);

			soundD.Play ();
		}
	}

	void OnTriggerExit (Collider col)
	{
		if(GetComponent<Collider>().gameObject.name == "D")
		{
			gameObject.GetComponent<Renderer> ().material.color = Color.white;

			soundD.Stop ();
		}
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
