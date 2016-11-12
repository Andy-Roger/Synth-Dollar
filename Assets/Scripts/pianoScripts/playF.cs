using UnityEngine;
using System.Collections;

public class playF : MonoBehaviour {

	public AudioSource soundF;
	private float startingPitch = 1f;
	private float halfStep = 1.059463094359f;


	void OnTriggerEnter (Collider col)
	{
		if(GetComponent<Collider>().gameObject.name == "F")
		{
			gameObject.GetComponent<Renderer> ().material.color = Color.magenta;

			soundF.pitch = startingPitch * (halfStep * halfStep * halfStep * halfStep * halfStep);

			soundF.Play ();
		}
	}

	void OnTriggerExit (Collider col)
	{
		if(GetComponent<Collider>().gameObject.name == "F")
		{
			gameObject.GetComponent<Renderer> ().material.color = Color.white;

			soundF.Stop ();
		}
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
