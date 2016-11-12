using UnityEngine;
using System.Collections;

public class looper : MonoBehaviour {
	public GameObject Cnote;
	public GameObject CSharp;
	public GameObject Dnote;
	public GameObject DSharp;
	public GameObject Enote;
	public GameObject Fnote;
	public GameObject FSharp;
	public GameObject Gnote;
	public GameObject GSharp;
	public GameObject Anote;
	public GameObject ASharp;
	public GameObject Bnote;
	public GameObject CTwonote;

	// Use this for initialization
	void Start () 
	{
		Cnote = GameObject.Find("C");
		CSharp = GameObject.Find("C-sharp");
		Dnote = GameObject.Find("D");
		DSharp = GameObject.Find("D-sharp");
		Enote = GameObject.Find("E");
		Fnote = GameObject.Find("F");
		FSharp = GameObject.Find("F-sharp");
		Gnote = GameObject.Find("G");
		GSharp = GameObject.Find("G-sharp");
		Anote = GameObject.Find("A");
		ASharp = GameObject.Find("A-sharp");
		Bnote = GameObject.Find("B");
		CTwonote = GameObject.Find("C2");

	}
	
	// Update is called once per frame
	void Update () 
	{
		if (gameObject.GetComponent<CapsuleCollider> ().enabled) {
			Cnote.GetComponent<AudioSource> ().loop = true;
			CSharp.GetComponent<AudioSource> ().loop = true;
			Dnote.GetComponent<AudioSource> ().loop = true;
			DSharp.GetComponent<AudioSource> ().loop = true;
			Enote.GetComponent<AudioSource> ().loop = true;
			Fnote.GetComponent<AudioSource> ().loop = true;
			FSharp.GetComponent<AudioSource> ().loop = true;
			Gnote.GetComponent<AudioSource> ().loop = true;
			GSharp.GetComponent<AudioSource> ().loop = true;
			Anote.GetComponent<AudioSource> ().loop = true;
			ASharp.GetComponent<AudioSource> ().loop = true;
			Bnote.GetComponent<AudioSource> ().loop = true;
			CTwonote.GetComponent<AudioSource> ().loop = true;


		} 

		else 
		{
			Cnote.GetComponent<AudioSource> ().loop = false;
			CSharp.GetComponent<AudioSource> ().loop = false;
			Dnote.GetComponent<AudioSource> ().loop = false;
			DSharp.GetComponent<AudioSource> ().loop = false;
			Enote.GetComponent<AudioSource> ().loop = false;
			Fnote.GetComponent<AudioSource> ().loop = false;
			FSharp.GetComponent<AudioSource> ().loop = false;
			Gnote.GetComponent<AudioSource> ().loop = false;
			GSharp.GetComponent<AudioSource> ().loop = false;
			Anote.GetComponent<AudioSource> ().loop = false;
			ASharp.GetComponent<AudioSource> ().loop = false;
			Bnote.GetComponent<AudioSource> ().loop = false;
			CTwonote.GetComponent<AudioSource> ().loop = false;
		}
	}
}
