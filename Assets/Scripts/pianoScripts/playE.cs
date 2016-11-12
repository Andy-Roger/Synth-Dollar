using UnityEngine;
using System.Collections;

public class playE : MonoBehaviour {

	public AudioSource soundE;
	private float startingPitch = 1f;
	private float halfStep = 1.059463094359f;


	void OnTriggerEnter (Collider col)
	{
		if(GetComponent<Collider>().gameObject.name == "E")
		{
			gameObject.GetComponent<Renderer> ().material.color = Color.magenta;

			soundE.pitch = startingPitch * (halfStep * halfStep * halfStep * halfStep);

			soundE.Play ();
		}
	}

	void OnTriggerExit (Collider col)
	{
		if(GetComponent<Collider>().gameObject.name == "E")
		{
			gameObject.GetComponent<Renderer> ().material.color = Color.white;

			soundE.Stop ();
		}
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
