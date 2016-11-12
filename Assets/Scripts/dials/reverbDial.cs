using UnityEngine;
using System.Collections;

public class reverbDial : MonoBehaviour {

	public GameObject thisChild;
	public GameObject ARCam;
	private float makeRange = 20f;



	// Use this for initialization
	void Start ()

	{
		ARCam = GameObject.Find ("ARCamera");
		thisChild = GameObject.Find ("reverb");
	}

	// Update is called once per frame
	void Update () 

	{
		ARCam.GetComponent<AudioReverbFilter> ().decayTime = Mathf.Abs(transform.rotation.y * makeRange);

		thisChild.transform.localScale = new Vector3 (thisChild.transform.localScale.x, Mathf.Abs (transform.rotation.y), thisChild.transform.localScale.z);
	}
}
