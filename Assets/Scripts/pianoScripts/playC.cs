using UnityEngine;
using System.Collections;

[RequireComponent(typeof(AudioSource))]


public class playC : MonoBehaviour {
	public AudioSource soundC;
	public AudioSource soundCTwo;
	public AudioSource soundCThree;
	public AudioSource soundCFour;
	private GameObject soundCardActive;


	void Start () 

	{
		soundCardActive = GameObject.Find ("sound");
	}


	void OnTriggerEnter (Collider col)
	{
		if(GetComponent<Collider>().gameObject.name == "C" && soundCardActive.GetComponent<CapsuleCollider>().enabled)
			
		{
			
			if (soundCardActive.transform.rotation.eulerAngles.y <= 120f) 
			{
				gameObject.GetComponent<Renderer> ().material.color = Color.magenta;

				soundCTwo.Play ();
			}
			if (soundCardActive.transform.eulerAngles.y > 120f && soundCardActive.transform.eulerAngles.y <= 240f) 
			{
				gameObject.GetComponent<Renderer> ().material.color = Color.magenta;

				soundCThree.Play ();
			}
			if (soundCardActive.transform.eulerAngles.y > 240f && soundCardActive.transform.eulerAngles.y <= 360f) 
			{
				gameObject.GetComponent<Renderer> ().material.color = Color.magenta;

				soundCFour.Play ();
			}

		}

		if(GetComponent<Collider>().gameObject.name == "C" && !soundCardActive.GetComponent<CapsuleCollider>().enabled)
		{
			gameObject.GetComponent<Renderer> ().material.color = Color.magenta;

			soundC.Play ();

		}
	}

	void OnTriggerExit (Collider col)
	{
		if(GetComponent<Collider>().gameObject.name == "C")
		{
			gameObject.GetComponent<Renderer> ().material.color = Color.white;

			soundC.Stop ();

			soundCTwo.Stop ();

			soundCThree.Stop ();

			soundCFour.Stop ();
		}
	}

	
	// Update is called once per frame
	void Update ()

	{

		Debug.Log (soundCardActive.transform.rotation.eulerAngles.y);
	}
}
