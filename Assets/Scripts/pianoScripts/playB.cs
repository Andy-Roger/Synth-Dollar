using UnityEngine;
using System.Collections;

public class playB : MonoBehaviour {

	public AudioSource soundB;
	private float startingPitch = 1f;
	private float halfStep = 1.059463094359f;


	void OnTriggerEnter (Collider col)
	{
		if(GetComponent<Collider>().gameObject.name == "B")
		{
			gameObject.GetComponent<Renderer> ().material.color = Color.magenta;

			soundB.pitch = startingPitch * (halfStep * halfStep * halfStep * halfStep * halfStep * halfStep * halfStep * halfStep * halfStep * halfStep * halfStep);

			soundB.Play ();
		}
	}

	void OnTriggerExit (Collider col)
	{
		if(GetComponent<Collider>().gameObject.name == "B")
		{
			gameObject.GetComponent<Renderer> ().material.color = Color.white;

			soundB.Stop ();
		}
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
