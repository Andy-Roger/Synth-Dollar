using UnityEngine;
using System.Collections;

public class playG : MonoBehaviour {

	public AudioSource soundG;
	private float startingPitch = 1f;
	private float halfStep = 1.059463094359f;


	void OnTriggerEnter (Collider col)
	{
		if(GetComponent<Collider>().gameObject.name == "G")
		{
			gameObject.GetComponent<Renderer> ().material.color = Color.magenta;

			soundG.pitch = startingPitch * (halfStep * halfStep * halfStep * halfStep * halfStep * halfStep * halfStep);

			soundG.Play ();
		}
	}

	void OnTriggerExit (Collider col)
	{
		if(GetComponent<Collider>().gameObject.name == "G")
		{
			gameObject.GetComponent<Renderer> ().material.color = Color.white;

			soundG.Stop ();
		}
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
