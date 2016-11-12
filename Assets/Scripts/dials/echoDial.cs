using UnityEngine;
using System.Collections;

public class echoDial : MonoBehaviour {

	public GameObject ARCam;
	public GameObject thisChild;
	private float makeRange = 5000f;



	// Use this for initialization
	void Start ()

	{
		ARCam = GameObject.Find ("ARCamera");
		thisChild = GameObject.Find ("echo");
	}

	// Update is called once per frame
	void Update () 

	{
		ARCam.GetComponent<AudioEchoFilter> ().delay = Mathf.Floor(Mathf.Abs(transform.rotation.y * makeRange));

		thisChild.transform.localScale = new Vector3 (thisChild.transform.localScale.x, Mathf.Abs (transform.rotation.y), thisChild.transform.localScale.z);
	}
}
