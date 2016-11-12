using UnityEngine;
using System.Collections;

public class chorusDial : MonoBehaviour {

	public GameObject ARCam;
	public GameObject thisChild;
	private float makeRange = 1.1f;


	// Use this for initialization
	void Start ()

	{
		ARCam = GameObject.Find ("ARCamera");
		thisChild = GameObject.Find ("chorus");
	}

	// Update is called once per frame
	void Update () 

	{
		ARCam.GetComponent<AudioChorusFilter> ().depth = Mathf.Abs(transform.rotation.y * makeRange); 

//		transform.position = new Vector3(transform.position.x, Mathf.Abs(transform.rotation.y) * div, transform.position.z);

		thisChild.transform.localScale = new Vector3 (thisChild.transform.localScale.x, Mathf.Abs (transform.rotation.y), thisChild.transform.localScale.z);
	}


}
