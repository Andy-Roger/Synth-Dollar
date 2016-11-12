using UnityEngine;
using System.Collections;

public class playC2 : MonoBehaviour {

	public AudioSource soundC2;
	private float startingPitch = 1f;
	private float halfStep = 1.059463094359f;


	void OnTriggerEnter (Collider col)
	{
		if(GetComponent<Collider>().gameObject.name == "C2")
		{
			gameObject.GetComponent<Renderer> ().material.color = Color.magenta;

			soundC2.pitch = startingPitch * (halfStep * halfStep * halfStep * halfStep * halfStep * halfStep * halfStep * halfStep * halfStep * halfStep * halfStep * halfStep);

			soundC2.Play ();
		}
	}

	void OnTriggerExit (Collider col)
	{
		if(GetComponent<Collider>().gameObject.name == "C2")
		{
			gameObject.GetComponent<Renderer> ().material.color = Color.white;

			soundC2.Stop ();
		}
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
