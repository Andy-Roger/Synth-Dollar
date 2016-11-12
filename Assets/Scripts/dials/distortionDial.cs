using UnityEngine;
using System.Collections;

public class distortionDial : MonoBehaviour {

	public GameObject ARCam;
	public GameObject thisChild;
	private float makeRange = 1.1f;



	// Use this for initialization
	void Start ()

	{
		ARCam = GameObject.Find ("ARCamera");
		thisChild = GameObject.Find ("distortion");
	}

	// Update is called once per frame
	void Update () 

	{
		ARCam.GetComponent<AudioDistortionFilter> ().distortionLevel = Mathf.Abs(transform.rotation.y * makeRange);

		thisChild.transform.localScale = new Vector3 (thisChild.transform.localScale.x, Mathf.Abs (transform.rotation.y), thisChild.transform.localScale.z);
	}
}
